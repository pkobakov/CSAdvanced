using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {

        public RepairShop(int capacity)
        {
            this.Capacity = capacity;
            this.Vehicles = new List<Vehicle>();
        }
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (this.Vehicles.Count < this.Capacity)
            {
                this.Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin)
        {
            var vehicle = this.Vehicles.FirstOrDefault(v => v.VIN == vin);
            if (vehicle == null)
            {
                return false;

            }
            this.Vehicles.Remove(vehicle);
            return true;
        }

        public int GetCount() => this.Vehicles.Count;
        public Vehicle GetLowestMileage()
        {
            return this.Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Vehicles in the preparatory:");

            foreach (var vehicle in this.Vehicles)
            {

                stringBuilder.AppendLine(vehicle.ToString());
            }

            return stringBuilder.ToString().TrimEnd();

        }
    }
}
