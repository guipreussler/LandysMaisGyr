using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    public class Encontrar5
    {
        public static void Renderizar5(List<Meter> list_meter)
        {
            string serialnum;

            Console.Write("\r\nInsert an Endpoint Serial Number: ");
            serialnum = Convert.ToString(Console.ReadLine().ToUpper());

            Meter Meter = SearchMeter(list_meter, serialnum);

            if (Meter == null || Meter.MeterState == 3)
            {
                Console.WriteLine("\r\nMeter Not Found in the System!");
            }
            else
            {
                Console.WriteLine("\r\nMeter Found in the System!\r\n");
                Console.Write($"Meter Serial Number: {Meter.SerialNumber}  |  ");
                Console.Write($"Meter Id: {Meter.MeterId}  |  ");
                Console.WriteLine($"Meter Number: {Meter.MeterNumber}");
                Console.Write($"Meter FirmwareVersion: {Meter.FirmwareVersion}  |  ");
                Console.Write($"Meter State: {Meter.MeterState}  |  ");

                if (Meter.MeterState == 0)
                {
                    Console.WriteLine("State register: Disconnected");
                }

                else if(Meter.MeterState == 1)
                {
                    Console.WriteLine("State register: Connected");
                }

                else if(Meter.MeterState == 2)
                {
                    Console.WriteLine("State register: Armed"); 
                }
            }
            Console.WriteLine("\r\n===================================================");
            Console.WriteLine("\r\nPress Enter to Return to Menu!");
            Console.ReadKey();
        }
        public static Meter SearchMeter(List<Meter> list_meter, string serialnum)
        {
            foreach(var item in list_meter)
            {
                if (item.SerialNumber.Equals(serialnum))
                {
                    return item;
                }
            }
            return null;
        }
    }
}