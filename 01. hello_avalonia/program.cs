using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;

namespace HelloWorldApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                         .UsePlatformDetect();

        public class App : Application
        {
            public override void OnFrameworkInitializationCompleted()
            {
                if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
                {
                    desktop.MainWindow = new MainWindow();
                }
                base.OnFrameworkInitializationCompleted();
            }
        }

        public class MainWindow : Window
        {
            public MainWindow()
            {
                Title = "Hello, World App"; // 윈도우 제목
                Width = 800;
                Height = 600;
                Content = new TextBlock
                {
                    Text = "Hello, World",
                    HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                    VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
                };
            }
        }
    }
}