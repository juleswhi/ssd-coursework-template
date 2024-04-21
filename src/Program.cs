using AS_SSD_Coursework.Views;

namespace YOUR_APP_NAME;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}