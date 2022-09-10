using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using System;
using System.Drawing;

namespace Test.MyControls
{
    public class ClickPanel : Button
    {
        Button btn1;
        
        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            btn1 = this.FindControl<Button>("btn1");
            btn1.Background = (Avalonia.Media.IBrush?)Brushes.Blue;
        }


    }
}
