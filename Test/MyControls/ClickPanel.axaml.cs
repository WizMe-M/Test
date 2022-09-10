using Avalonia.Controls;
using Avalonia.Interactivity;
using Brushes = Avalonia.Media.Brushes;

namespace Test.MyControls
{
    public class ClickPanel : Button
    {
        /// <summary>
        /// Обработчик нажатия на кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonClick(object sender)
        {
            if (sender is not Button clicked) return;
            
            clicked.Background = Brushes.Aquamarine;
        }
        
    }
}
