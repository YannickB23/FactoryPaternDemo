using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternDemo.Interfaces
{
    public interface IMachine
    {
        string Name { get; }
        string TurnOn();
        string TurnOff();
    }
}
