using FactoryPaternDemo.Interfaces;
using FactoryPaternDemo.Models;
using System;
using System.Windows.Forms;

namespace FactoryPaternDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //IMachine computer = new Computer();

            string instance = "laptop";
            
            //IMachine machine = GetInstance(instance);
            
            IMachine machine = new MachineFactory().CreatInstance(instance);
            TxtName.Text = machine.Name;
            TxtTurnOn.Text = machine.TurnOn();
            TxtTurnOff.Text = machine.TurnOff();
        }
        //private static IMachine GetInstance(string instance)
        //{
        //    switch (instance)
        //    {
        //        case "robot":
        //            return new Robot();
        //        case "computer":
        //            return new Computer();
        //        default:
        //            return null;
        //    }
        //}

    }
}
