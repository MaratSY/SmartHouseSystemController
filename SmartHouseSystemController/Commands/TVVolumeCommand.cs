using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseSystemController.Commands
{
    class TVVolumeCommand : ICommand
    {
        TV tv;
        
        public int VolumeLevel { get => tv.Volume;}
        private const int  minVolumeLevel = 0;
        private const int maxVolumeLevel = 100; 
        public TVVolumeCommand(TV concreteTV)
        {
            tv = concreteTV;
            tv.Volume = 0;
        }
        public void Execute()
        {
            if (tv.Volume < maxVolumeLevel && tv.Power == true)
            {
                tv.Volume++;
            }
            Console.WriteLine($"Громкость 0>>>>{VolumeLevel}>>>>100");
        }

        public void Undo()
        {
            if (tv.Volume > minVolumeLevel && tv.Power == true)
            {
                tv.Volume--;
            }
            Console.WriteLine($"Громкость 0<<<<{VolumeLevel}<<<<100");
        }
    }
}
