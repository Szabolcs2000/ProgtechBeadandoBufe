﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject
{
    internal class LogForDeleteDessert :ILog
    {
        public void Log(string messageType, string name)
        {
            StreamWriter sw = new StreamWriter("log.txt", true, Encoding.UTF8);
            sw.WriteLine(DateTime.Now.ToString() + " - " + messageType + " - " +
                $"Az admin törölt egy desszertet az étlapról. [{name}]");
            sw.Close();
        }
    }
}
