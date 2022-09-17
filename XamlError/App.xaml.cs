using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

namespace XamlError;

public partial class App : Application
{
    public App()
    {
        DispatcherUnhandledException += App_DispatcherUnhandledException;
    }

    private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        var exception = e.Exception;
        e.Handled = true;
        Debug.WriteLine(exception.ToString());
        MessageBox.Show(exception.Message);
        Shutdown();
    }
}
