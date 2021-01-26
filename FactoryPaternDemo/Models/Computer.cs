using FactoryPaternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternDemo.Models
{
    public class Computer : IMachine
    {
        public string Name => "Computer";

        public string TurnOff()
        {
            return "Computer is shutting down.";
        }

        public string TurnOn()
        {
           return"Computer is starting.";
        }
    }
}
