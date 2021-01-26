using FactoryPaternDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPaternDemo.Models
{
    public class MachineFactory
    {
        Dictionary<string, Type> machines;
        public MachineFactory()
        {
            LoadInstances();
        }
        public IMachine CreatInstance(string instance)
        {
            Type t = GetTypeToCreate(instance);
            if (t == null)
            {
                return null;
            }
            return Activator.CreateInstance(t) as IMachine;
        }
        public Type GetTypeToCreate(string machineName)
        {
            foreach (var item in machines)
            {
                if (item.Key.Contains(machineName))
                {
                    return machines[item.Key];
                }
            }
            return null;
        }
        private void LoadInstances()
        {
            machines = new Dictionary<string, Type>();
            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IMachine).ToString()) != null)
                {
                    machines.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
