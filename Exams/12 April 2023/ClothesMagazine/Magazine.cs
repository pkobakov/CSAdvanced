using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesMagazine
{
    public class Magazine
    {
        string type;
        private int capacity;
        private List<Cloth> clothes;
        public Magazine(string type, int capacity) 
        {
           this.clothes = new List<Cloth>();
           this.Type = type;
           this.Capacity = capacity;

        }

        public string Type { get { return type; } set { type = value; } }

        public int Capacity { get { return capacity; } set { capacity = value; } }

        public List<Cloth> Clothes { get {  return clothes; } }

        public void AddCloth(Cloth cloth) 
        {
            if (this.Capacity > this.GetClothCount() )
            {
               this.clothes.Add( cloth );
                
            }

        }
        public bool RemoveCloth(string color) 
        {
            var cloth = this.clothes.FirstOrDefault(c => c.Color == color); 

            if (cloth == null)
            {
                return false;
            }

            clothes.Remove(cloth);    
            return true;
        }

        public Cloth GetSmallestCloth() 
        {

            return this.clothes.OrderBy(c => c.Size).FirstOrDefault();
        }

        public Cloth GetCloth(string color) 
        {
            return this.clothes.FirstOrDefault(c => c.Color == color);
        }

        public int GetClothCount() 
        {
            return this.clothes.Count;
        }

        public string Report ()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{this.Type} magazine contains:");

            foreach (var cloth in this.clothes.OrderBy(c => c.Size)) 
            {
                stringBuilder.AppendLine(cloth.ToString());
            }
            

            return stringBuilder.ToString().TrimEnd();
        } 
    }
}
