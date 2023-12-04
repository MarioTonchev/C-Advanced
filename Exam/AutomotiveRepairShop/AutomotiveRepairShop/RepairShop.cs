using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }

        public int GetCount()
        {
            return Vehicles.Count;
        }

        public Vehicle GetLowestMileage()
        {
            int min = int.MaxValue;
            foreach (Vehicle vehicle in Vehicles)
            {
                if (vehicle.Mileage < min)
                {
                    min = vehicle.Mileage;
                }
            }
            return Vehicles.First(v => v.Mileage == min);
        }

        public bool RemoveVehicle(string vin)
        {
            if (Vehicles.Any(v => v.VIN == vin))
            {
                Vehicles.RemoveAll(v => v.VIN == vin);
                return true;
            }
            return false;
        }

        public string Report()
        {
            StringBuilder sb = new();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (var item in Vehicles)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
