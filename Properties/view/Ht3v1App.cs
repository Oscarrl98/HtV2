using Ht3v1App.Properties.service;

namespace Ht3v1App.Properties.view
{
    public class Ht3v1App
    {
        public static void Main(string[] args)
        {
            FormatFile nFormat= new FormatFile();
            nFormat.ConverFile(args);
        }
    }
}