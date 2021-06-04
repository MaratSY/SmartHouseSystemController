using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseSystemController.Commands
{
    public class LightBulbCommand : ICommand
    {
        public LightBulb lightBulb;

        public bool IsOn { get => lightBulb.Power;  }
        public LightBulbCommand(LightBulb concreteLightBulb)
        {
            lightBulb = concreteLightBulb;
        }

        public void Execute()
        {
            if (IsOn == false)
            {
                lightBulb.Power = true;
            }
            Console.WriteLine("Ламочка светит");
        }

        public void Undo()
        {
            if (IsOn)
            {
                lightBulb.Power = false;
            }
            Console.WriteLine("Лампочка не светит");
        }
    }
}
