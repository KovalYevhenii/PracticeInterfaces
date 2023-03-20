using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PracticeInterfaces
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents()
        {
            return _components;
        }
        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
      
        public string GetInfo()
        {
            string info = $"Type: {GetRobotType()}\nComponents:{string.Join(",", GetComponents())}\n";

            return info;
        }

    }
}
