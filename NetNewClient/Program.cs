namespace NetNewClient;

static class Program
{
    public static Form1? MainFormInstance { get; private set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        MainFormInstance = new Form1();
        Application.Run(MainFormInstance);

    }    
}