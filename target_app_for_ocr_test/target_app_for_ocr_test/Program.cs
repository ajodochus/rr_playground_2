using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Globalization;

namespace target_app_for_ocr_test
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            GetDataTableFromCsv();
        }

        public static void GetDataTableFromCsv()
        {
            
            
        }
    }
    
}

public class Contact
{
    public string Name { get; set; }
    public string Phone { get; set; }
}
    