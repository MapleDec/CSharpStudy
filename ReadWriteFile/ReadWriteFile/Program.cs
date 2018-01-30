using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "Maple, please keep do it!";
            String filePath = WriteFile(data);

            Console.WriteLine(filePath);
            string strData = ReadFile(filePath);
            Console.WriteLine(strData);  
            Console.ReadKey();
        }

        // write data to file
        private static String WriteFile(string data)
        {
            System.DateTime currentTime = System.DateTime.Now;
            string strYearMonthDay = currentTime.AddDays(-1).ToString("yyyMMdd");
            string fileName = "MyFileSend" + strYearMonthDay + ".txt";
            string currentDir = System.AppDomain.CurrentDomain.BaseDirectory + @"SaveDir";

            if (System.IO.Directory.Exists(currentDir))
            {
                System.IO.Directory.CreateDirectory(currentDir);
            }

            String filePath = currentDir + fileName;
            System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, false);
            file.Write(data);
            file.Close();
            file.Dispose();

            return filePath;
        }

        private static String ReadFile(String filePath)
        {
            string strData = "";

            try
            {
                string line;
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        strData = line;
                    }
                }
            }
            catch (Exception e)
            {
                // show error info to customer
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return strData;
        }
    }
}
