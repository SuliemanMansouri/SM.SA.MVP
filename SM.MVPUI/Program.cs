
using SM.MathImplementation;
using SM.MVPUI;
using SM.UI.Contracts;

namespace SM.UI
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
            Form1 form1 = new();
            Form1Presenter form1Presenter = new Form1Presenter(form1,
                                                               new MyMathLibrary());
            Application.Run(form1);
        }
    }
}