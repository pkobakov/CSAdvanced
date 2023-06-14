using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        
        private string name;
        private string type;
        double rate;
        int days;

        public Renovator(string name, string type, double rate, int days)
        {
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
            this.Days = days;
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }
        public int Days { get; set; }
        public bool Hired { get; set; } = false;
        public bool Paid { get; set; } = false;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"-Renovator: {this.Name}");
            stringBuilder.AppendLine($"--Specialty: {this.Type}");
            stringBuilder.AppendLine($"--Rate per day: {this.Rate} BGN");
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
