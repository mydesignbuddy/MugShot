using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MugShot.Lib
{
    public class Media
    {
        private string name;

        public string Name { 
            get {
                return (name != null ? name.ToString() : "No Name");
            }
            set {
                name = value;
            }
        }
    }
}
