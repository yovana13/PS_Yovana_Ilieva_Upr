using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PS_31_Yovana_Ilieva_Upr2_working
{
    static public class Logger
    {
        //static public IEnumerable<string> currentSessionActiviies();
        private static List<string> currentSessionActiviies = new List<string>();

        public static void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ";" + LoginValidation.CurrentUsername + ";" +
                                  LoginValidation.CurrentUserRole + ";" + activity;

            if (File.Exists("test.txt") == true)
            {
                File.AppendAllText("test.txt", activityLine + Environment.NewLine);
            }

            currentSessionActiviies.Add(activityLine);
        }

        public static IEnumerable<string> GetCurrentSessionActivities(string filter)
        {
            List<string> filteredActivities = (from activity in currentSessionActiviies where activity.Contains(filter)
                                               select activity).ToList();
            return filteredActivities;
        }

        public static void ReadFullLog()
        {
            StreamReader outputFile = new StreamReader("test.txt");
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                var line = outputFile.ReadLine();

                if (line != null)
                {
                    sb.Append(line);
                }
                else
                    break;

                Console.Write(sb);
            }

            outputFile.Close();
        }
    }
}
