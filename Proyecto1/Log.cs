using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Proyecto1
{
    public class Log
    {
        private string Path = "";


        public Log(string Path)
        {
            this.Path = Path;
        }

        public void Add(string sLog)
        {

            string nombre = GetNameFile();
            string cadena = "";

            cadena += DateTime.Now + " - " + sLog + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();

        }

        #region HELPER
        private string GetNameFile()
        {
            string nombre = "";

            nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

            return nombre;
        }


        #endregion
    }
}

