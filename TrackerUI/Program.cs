using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialise the DB connection
            TrackerLibrary.GlobalConfig.InitializeConnection(true, true);
            
            // Application.Run(new TournamentDashboardForm());
            Application.Run(new CreatePrizeForm());
        }
    }
}