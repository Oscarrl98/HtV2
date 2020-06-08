
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ht3v2App.Properties.service;

namespace service{
    public abstract class FormaterDecorator : IFormater {

        public FormaterDecorator() {
        }

        protected IFormater format;
        
        public void SetFormat(IFormater format)
        {
            this.format = format;
        }


        public abstract void ConverFile(string[] archivo);
    }
}    