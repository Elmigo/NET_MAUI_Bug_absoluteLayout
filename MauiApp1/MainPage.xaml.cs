using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private ObservableCollection<TestList> testCollection = new ObservableCollection<TestList>();

    public MainPage()
	{
		InitializeComponent();

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testCollection.Add(new TestList
        {
            string1 = "Welcome to .NET MAUI",
            string2 = "Testing application"
        });

        testView.ItemsSource = testCollection;
    }
}