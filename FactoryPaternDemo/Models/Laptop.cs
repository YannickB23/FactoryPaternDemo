using FactoryPaternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternDemo.Models
{
    public class Laptop : IMachine
    {
        public string Name => "Laptop";

        public string TurnOff()
        {
            return "Laptop is shutting down.";
        }

        public string TurnOn()
        {
            return "Laptop is starting.";
        }
    }
}
