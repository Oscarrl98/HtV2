using Ht3v2App.Properties.service;

namespace Ht3v2App.Properties.view
{
    internal class Ht3v2App
    {
        public static void Main(string[] args)
        {
            FormatFacade facade =new FormatFacade();
            facade.Format(args);
        }
    }
}