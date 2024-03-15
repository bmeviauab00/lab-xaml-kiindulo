using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace HelloXaml;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void myButton_Click(object sender, RoutedEventArgs e)
    {
        myButton.Content = "Clicked";
    }
}
