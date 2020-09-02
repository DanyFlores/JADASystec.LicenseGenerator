using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JADASystect.CrossCutting.Helpers
{
    public static class ErrorLogHelper
    {
        public static void AddExcFileTxt(Exception ex, string funcion)
        {
            try
            {
                string basePath = "Resources/Support/";
                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }
                string mydocpath = basePath + "ErrorLog.txt";
                if (File.Exists(mydocpath))
                {
                    using (StreamWriter outputFile = new StreamWriter(mydocpath, true))
                    {
                        outputFile.WriteLine(ex.HResult + " - " + DateTime.Now + " - " + funcion + " - " + ex.Message);
                    }
                }
                else
                {
                    using (StreamWriter outputFile = new StreamWriter(mydocpath))
                    {
                        outputFile.WriteLine(ex.HResult + " - " + DateTime.Now + " - " + funcion + " - " + ex.Message);
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
