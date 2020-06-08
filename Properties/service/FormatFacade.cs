using System;
using service;

namespace Ht3v2App.Properties.service{
    public class FormatFacade {

        public FormatFacade() {
        }

        public void Format(String[] args) {
            String format = args[args.Length - 1];//ultimo elemento del args
            Array.Resize(ref args, args.Length - 1);
            IFormater formater1=new FormatFile();
            switch (format)
            {   case "CSV":
                    formater1.ConverFile(args);
                    break;
                case "HTML":
                    FormaterDecorator deco=new FormatHTMLDecorator();
                    deco.SetFormat(formater1);
                    deco.ConverFile(args);
                    break;
                case "XML":
                    FormaterDecorator deco2=new FormatXMLDecorator();
                    deco2.SetFormat(formater1);
                    deco2.ConverFile(args);
                    break;
                case "JSON":
                    FormaterDecorator deco3=new FormatJSONDecorator();
                    deco3.SetFormat(formater1);
                    deco3.ConverFile(args);
                    break;
                default: System.Console.WriteLine("No ha especificado ningun formato");
                    break;
            }
            
        }

    }
}