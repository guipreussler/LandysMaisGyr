using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    public class Listar4
    {
        public static void Renderizar4(List<Meter> list_meter)
        {
            Console.WriteLine("\r\n################# List of Registered Meters #################\r\n");

            foreach (Meter meter in list_meter)
            {
                if(meter.MeterState == 3)
                {

                }
                else
                {
                    Console.Write($"Meter Serial Number: {meter.SerialNumber}  |  ");
                    Console.Write($"Meter Id: {meter.MeterId}  |  ");
                    Console.WriteLine($"Meter Number: {meter.MeterNumber}");
                    Console.Write($"Meter FirmwareVersion: {meter.FirmwareVersion}  |  ");
                    Console.Write($"Meter State: {meter.MeterState}  |  ");
                
                    if (meter.MeterState == 0)
                    {
                        Console.WriteLine("State register: Disconnected");
                    }
                    else if(meter.MeterState == 1)
                    {
                       Console.WriteLine("State register: Connected");
                    }
                    else if(meter.MeterState == 2)
                    {
                        Console.WriteLine("State register: Armed");
                    } 
                    Console.WriteLine("\r\n===============================================================\r\n");
                }         
            }
            Console.WriteLine("\r\nPress Enter to Return to Menu!");
            Console.ReadKey();     
        }
        
    }

}