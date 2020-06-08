using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using service;

namespace Ht3v2App.Properties.service{
    public class FormatJSONDecorator : FormaterDecorator {

        public FormatJSONDecorator() {
        }
        public void ConverToJSON(String[] archivo) {
            float tamaño = archivo.Length;
            String lines = "";
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "json.json"), "");
            System.Console.WriteLine("\nArchivo(s) Formato JSON\n");
            for (int i = 0; i < tamaño; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                List<string> result = text.Split(' ').ToList();
                System.Console.WriteLine("\"Archivo No"+ (i+1)+"\": [");
                File.AppendAllText(Path.Combine(docPath, "json.json"), ("\"Archivo No"+ (i+1)+"\": [") );
                result.ForEach(delegate(String name)
                {
                    Console.WriteLine("\t {\"" +name+"\"" + "},");
                    lines = "\t {\"" +name+"\"" + "},";
                    File.AppendAllText(Path.Combine(docPath, "json.json"),lines );
                });
                System.Console.WriteLine("\t ]\n");
                File.AppendAllText(Path.Combine(docPath, "json.json"), ("\t ]\n"));
            }
        }

        public override void ConverFile(string[] archivo)
        {
            this.ConverToJSON(archivo);
        }
    }
}