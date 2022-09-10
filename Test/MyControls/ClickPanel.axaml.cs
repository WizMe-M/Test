using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using Avalonia.VisualTree;
using Brushes = Avalonia.Media.Brushes;

namespace Test.MyControls
{
    public class ClickPanel : Button
    {
        protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
        {
            base.OnApplyTemplate(e);
            var panel = e.NameScope.Get<StackPanel>("ButtonPanel");
            foreach (var logical in panel.GetLogicalChildren())
            {
                if (logical is not Button btn) continue;
                btn.Click += OnButtonClick;
            } 
        }

        /// <summary>
        /// Обработчик нажатия на кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonClick(object? sender, RoutedEventArgs e)
        {
            if (sender is not Button clicked) return;

            clicked.Background = Brushes.Aquamarine;
        }
    }
}