using System;
using System.Collections.Generic;
using System.Linq;
namespace hw_13_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices1 = new List<Device>()
            {
                new Device("Phone1","Samsung",20055),
                new Device("IPhone1","Apple",20030),
                new Device("Phone2","Xsaomi",20006),
                new Device("Phone3","Motorola",20009),
            };
            List<Device> devices2 = new List<Device>()
            {
                new Device("Phone4","Samsung",20005),
                new Device("IPhone2","Apple2",20002),
                new Device("Phone5","Xsaomi",20001),
                new Device("Phone6","Motorola2",2000),
            };

            var differnce = devices1.Where(d1 => !devices2.Any(d2 => d2.Manufacturer == d1.Manufacturer)).ToList();
            var intersection = devices1.Where(d1 => devices2.Any(d2 => d2.Manufacturer == d1.Manufacturer)).ToList();
            var union = devices1.Concat(devices2).Distinct().ToList();

            Console.WriteLine("====================================");
            Console.WriteLine("difference: d1 : d2");
            Show(differnce);
            Console.WriteLine("====================================");

            Console.WriteLine("inter d1 & d2");
            Show(intersection);
            Console.WriteLine("====================================");

            Console.WriteLine("device1 | device2");
            Show(union);



            static void Show(List<Device> value)
            {
                foreach (var item in value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
