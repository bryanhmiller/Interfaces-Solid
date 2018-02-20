using System;
using System.Collections.Generic;
using Transportation.Vehicle;

namespace Transportation 
{
    public class Transport
    {
        public string Type { get; set; }
        public Transport(string type)
        {
            Type = type;
        }
        public void AddVehicle(Vehicle newVehicle)
        {
            Vehicles.Add(newVehicle);
        }
        
    }
}
