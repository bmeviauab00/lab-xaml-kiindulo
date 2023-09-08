using HelloXaml.Models;

using Microsoft.UI.Xaml;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HelloXaml;

public sealed partial class MainWindow : Window
{
    public Person NewPerson { get; set; }
    public ObservableCollection<Person> People { get; set; }

    public MainWindow()
    {
        InitializeComponent();

        NewPerson = new Person()
        {
            Name = "Eric Cartman",
            Age = 8
        };

        People = new ObservableCollection<Person>()
        {
          new Person() { Name = "Peter Griffin", Age = 40 },
          new Person() { Name = "Homer Simpson", Age = 42 },
        };

        rootGrid.DataContext = this;
    }

    private void AddButton_Click(object sender, RoutedEventArgs e)
    {
        People.Add(NewPerson);
    }

    private void DecreaseButton_Click(object sender, RoutedEventArgs e)
    {
        NewPerson.Age--;
    }

    private void IncreaseButton_Click(object sender, RoutedEventArgs e)
    {
        NewPerson.Age++;
    }
}
