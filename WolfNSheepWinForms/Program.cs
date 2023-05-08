namespace WolfNSheepWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Presenter p = new Presenter(new FrmView(), new Model());

            Application.Run((Form)p.ShowView());
        }
    }
}