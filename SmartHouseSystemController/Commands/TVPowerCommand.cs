using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseSystemController.Commands
{
    public class TVPowerCommand : ICommand
    {
        public TV tv;
                
        public TVPowerCommand(TV concreteTV)
        {
            tv = concreteTV;
        }
        public void Execute()
        {
            if (tv.Power == false)
            {
                tv.Power = true;
                Console.WriteLine("Телевизор включен");
            }            
        }
        public void Undo()
        {
            if (tv.Power == true)
            {
                tv.Power = false;
                Console.WriteLine("Телевизор выключен");
            }
        }
    }
}
