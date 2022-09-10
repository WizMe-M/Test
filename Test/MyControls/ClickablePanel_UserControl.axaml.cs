using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace Test.MyControls;

public partial class ClickablePanel_UserControl : UserControl
{
    public ClickablePanel_UserControl()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        if (sender is not Button clicked) return;

        clicked.Background = Brushes.Aquamarine;
    }
}