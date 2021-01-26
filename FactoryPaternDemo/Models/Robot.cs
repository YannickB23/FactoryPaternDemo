using FactoryPaternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternDemo.Models
{
    public class Robot : IMachine
    {
        public string Name => "Robot";

        public string TurnOff()
        {
            return"Robot is going to sleep.";
        }

        public string TurnOn()
        {
            return "Robot is starting.";
        }
    }
}
