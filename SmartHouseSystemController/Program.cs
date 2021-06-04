using SmartHouseSystemController.Commands;
using System;

namespace SmartHouseSystemController
{
    class Program
    {
        static void Main(string[] args)
        {
            TV samsungTV = new();
            LightBulb xiaomiLightBulb = new();
            Kettle redmondKettle = new();

            SmartAssistent Alice = new();

            Alice.AddCommand(new TVPowerCommand(samsungTV));
            Alice.AddCommand(new TVVolumeCommand(samsungTV));
            Alice.AddCommand(new TVVolumeCommand(samsungTV));
            Alice.AddCommand(new TVVolumeCommand(samsungTV));
            Alice.AddCommand(new LightBulbCommand(xiaomiLightBulb));
            Alice.AddCommand(new KettlePowerCommand(redmondKettle));
            Alice.ExecuteCommands();
            
            Console.ReadLine();
            Alice.UndoCommands();

            Console.ReadLine();
        }
    }
}
