using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SmartHouseSystemController.Commands
{
    class KettlePowerCommand : ICommand
    {
        Kettle kettle;
        public bool IsOn { get => kettle.Power; }
        public int Temperature { get => kettle.Temperature; set => kettle.Temperature = value; }
        public KettlePowerCommand(Kettle concreteKettle)
        {
            kettle = concreteKettle;
            Temperature = 20;
        }

        public void Execute()
        {
            if (IsOn == false)
            {
                kettle.Power = true;
                Console.Write("Чайник нагревает воду. ");
                while (Temperature < 100)
                {
                    Temperature++;
                    Console.Write($"{Temperature} ");
                    Thread.Sleep(20);
                }
                kettle.Power = false;
                Console.WriteLine("Чайник закипел");
            }
        }

        public void Undo()
        {
            if (IsOn)
            {
                kettle.Power = false;
            }
            Console.WriteLine("Чайник выключен");
        }
    }
}
