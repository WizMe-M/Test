using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Test.Views;

public partial class TestWindow : Window
{
    public TestWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}