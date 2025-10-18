using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Management;
using System.IO;


namespace PC_STORE
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (ValidHDv2() == false)
            //{
            //    MessageBox.Show(" لا يمكنك استعمال هذه التطبيقة قي هذا الجهاز الغير المصرح به. يمكنــــك طلــــب التصــــريح من طرف مطـــور التطبيقــة ", " Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    Application.Run(new about());
            //    return;
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
           
        }

        //private static bool ValidHD()
        //{
        //    string hdSN = String.Empty;
        //    ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("select * from Win32_DiskDrive");
        //    foreach (ManagementObject wmi_HDD in moSearcher.Get())
        //    {
        //        hdSN = wmi_HDD["SerialNumber"].ToString();
        //    }


        //    if (hdSN == "            Z991NC15" || hdSN == "            Z3TSFQHW" || hdSN == "Z3TSFQHW            " || hdSN == "WD-WCC2ETA99022     " || hdSN == "     WD-WCC2ETA99022" || hdSN == "            5VY1S0E4" || hdSN == "5VY1S0E4            " || hdSN == "2020202020202020202020205635315930533445" || hdSN == "      PVG904ZMR61UYV" || hdSN == "PVG904ZMR61UYV      " || hdSN == "2020202020205650394734304d5a365255315659" || hdSN == "335a535433463335202020202020202020202020")  // sn allow
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

       

        private static bool ValidHDv2()
        {
            var lines = File.ReadAllLines("PC_STORE.vshost.dll");
            string hdSN = String.Empty;

            ManagementObjectSearcher moSearcher = new ManagementObjectSearcher("select * from Win32_DiskDrive");
            foreach (ManagementObject wmi_HDD in moSearcher.Get())
            {
                hdSN = wmi_HDD["SerialNumber"].ToString();
            }


            if (lines.Contains(hdSN))
            {
                File.AppendAllText("PC_STORE.vshost.dll", "");
                return true;

            }

             
            else
            {
                return false;
            }
        }


    }
}
