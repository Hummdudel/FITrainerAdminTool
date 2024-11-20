using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FITrainerAdminTool.DBClasses;
using FITrainerAdminTool.TableClasses;

namespace FITrainerAdminTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            string[] tableData = DBLernkarten.ReadLernkartenIntoStringArray();
            string filePath = "d:\\\\CSHARP\\Test.csv";
            
            FileOperations.ExportAsCSV(filePath, tableData);
            */

            /*List<Lernkarte> lerkartenliste = DBLernkarten.ReadLernkartenListJSON();
            FileOperations.ExportLernkartenToJson(lerkartenliste);*/
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        
            
        }
    }
}