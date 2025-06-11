using Lesson13_Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        // создаем умный дом
        var smartHome=new SmartHome();
        // создаем фабрики устройств
        var lampFactory=new SmartLampFactory();
        var doorFactory=new SmartDoorFactory();
        var thermostatFactory=new SmartThermostatFactory();
        //Населяем комнаты устройствами
        // Hall
        smartHome.AddSmartDevices(lampFactory, "Lamp in Hall", Zone.Hall);
        smartHome.AddSmartDevices(doorFactory, "Door in Hall", Zone.Hall);
        smartHome.AddSmartDevices(thermostatFactory, "Thermostat in Hall", Zone.Hall);
        // Livingroom
        smartHome.AddSmartDevices(lampFactory, "Lamp in LivingRoom", Zone.Livingroom);
        smartHome.AddSmartDevices(doorFactory, "Door in LivingRoom", Zone.Livingroom);
        smartHome.AddSmartDevices(thermostatFactory, "Lamp in LivingRoom", Zone.Livingroom);
        // Kitchen
        smartHome.AddSmartDevices(lampFactory, "Lamp in Kitchen", Zone.Kitchen);
        smartHome.AddSmartDevices(doorFactory, "Door in Kitchen", Zone.Kitchen);
        smartHome.AddSmartDevices(thermostatFactory, "Thermostat in Kitchen", Zone.Kitchen);
        // Bathroom
        smartHome.AddSmartDevices(lampFactory, "Lamp in Bathroom", Zone.Bathroom);
        smartHome.AddSmartDevices(doorFactory, "Door in Bathroom", Zone.Bathroom);
        smartHome.AddSmartDevices(thermostatFactory, "Thermostat in Bathroom", Zone.Bathroom);
        // Naster Bedroom
        smartHome.AddSmartDevices(lampFactory, "Lamp in MasterBedroom", Zone.MasterBedroom);
        smartHome.AddSmartDevices(doorFactory, "Door in MasterBedroom", Zone.MasterBedroom);
        smartHome.AddSmartDevices(thermostatFactory, "Thermostat in MasterBedroom", Zone.MasterBedroom);
        // Children Bedroom
        smartHome.AddSmartDevices(lampFactory, "Lamp in ChildrenBedroom", Zone.ChildrenBedroom);
        smartHome.AddSmartDevices(doorFactory, "Door in ChildrenBedroom", Zone.ChildrenBedroom);
        smartHome.AddSmartDevices(thermostatFactory, "Thermostat in ChildrenBedroom", Zone.ChildrenBedroom);
        // Проходим по всем комнатам
        foreach(Zone zone in Enum.GetValues(typeof(Zone)))
        {
            // Включаем, выключаем свет
            smartHome.ChangeLight(zone,true);
            Thread.Sleep(1000);
            smartHome.ChangeLight(zone, false);
            Thread.Sleep(1000);
            // Открываем, закрываем двери
            smartHome.ChangeDoorLocked(zone, true);
            Thread.Sleep(1000);            
            smartHome.ChangeDoorLocked(zone, false);
            Thread.Sleep(1000);
            // Устанавливаем температуру 25 град
            smartHome.ChangeTemptrature(zone,25);
            Thread.Sleep(1000);
        }
    }
}