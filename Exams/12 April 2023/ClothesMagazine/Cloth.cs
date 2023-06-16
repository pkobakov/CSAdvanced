using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMagazine
{
    public class Cloth
    {
        private string color;
        private int size;
        private string type;
        public Cloth(string color, int size, string type)
        { 
           this.Color = color;
           this.Size = size;
           this.Type = type;
        }

        public string Color { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"Product: {this.Type} with size {this.Size}, color {this.Color}";
        }
    }
}
