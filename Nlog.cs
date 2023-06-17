using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogandCRUD
{
   public  class Nlog
    {
        public Logger logging = LogManager.GetCurrentClassLogger();

        public void Debug(string message)
        {
            logging.Debug(message);
        }

        public void Info(string message)
        {
            logging.Info(message);
        }

        public void Warn(string message) 
        {
            logging.Warn(message);
        }

        public void Error(string message) 
        {
            logging.Error(message);
        }
    }

    public class attendance
    {
        Nlog logger = new Nlog();

        public void check()
        {
            Random random= new Random();    
            int check = random.Next(0, 1);

            logger.Debug("Check Employee Attendance");

            if (check == 1) 
            {
               // Console.WriteLine("Employee is present");
                logger.Info("Employee is present");
            }
            else
            {
               // Console.WriteLine("Employee is Absent");
                logger.Info("Employee is Absent");
            }
        }
    }
}
