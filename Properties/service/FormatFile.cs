using System;
using System.IO;
using service;

namespace Ht3v2App.Properties.service{
    public class FormatFile : IFormater {

        public FormatFile() {
        }

        public void ConverFile(string[] archivo)
        {
            System.Console.WriteLine("Archivo(s) en CSV");
            float tamaño = archivo.Length;
            String lines = "";
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "csv.csv"), "");
            for (int i = 0; i < tamaño; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("Archivo No. : " +(i+1)+"\n"+text + "\n");
                lines = "Archivo No. : " + (i + 1) + "\n" + text + "\n";
                File.AppendAllText(Path.Combine(docPath, "csv.csv"),lines );
                
            }
        }
    }
}