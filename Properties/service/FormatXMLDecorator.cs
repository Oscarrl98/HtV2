using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using service;

namespace Ht3v2App.Properties.service{
    public class FormatXMLDecorator : FormaterDecorator {

        public FormatXMLDecorator() {
        }
        
        public void ConvertToXML(String[] archivo) {
            float tamaño = archivo.Length;
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "xml.xml"), "");
            for (int i = 0; i < tamaño; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                List<string> result = text.Split(' ').ToList();
                System.Console.WriteLine("<Archivo" + (i + 1)+">");
                File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("<Archivo" + (i + 1)+">"));
                result.ForEach(delegate(String name)
                {
                    Console.WriteLine("   <parrafo> " + name + " </parrafo>");
                    File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("   <parrafo> " + name + " </parrafo>"));
                });
                System.Console.WriteLine("</Archivo" + (i + 1)+"> \n");
                File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("</Archivo" + (i + 1)+"> \n"));
            }
            
        }
        
        public override void ConverFile(string[] archivo)
        {
            this.ConvertToXML(archivo);
        }

        
    }
}