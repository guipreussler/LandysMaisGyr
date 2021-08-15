using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    public class Editar2
    {
        public static void Renderizar2(List<Meter> list_meter)
        {
            string serialnum, meterstate = "";

            Console.Write("\r\nInsert an Endpoint Serial Number: ");
            serialnum = Convert.ToString(Console.ReadLine().ToUpper());

            Meter Meter = SearchMeter(list_meter, serialnum);

            if(Meter == null || Meter.MeterState == 3)
            {
                Console.WriteLine("\r\nMeter Not Found in the System!");
            }
            else
            {
                foreach (var meter in list_meter)
                {

                    if (meter.SerialNumber.Equals(serialnum))
                    {
                        if(meter.MeterState == 0)
                        {
                            meterstate = "Disconnected";
                        }
                        else if(meter.MeterState == 1)
                        {
                            meterstate = "Connected";
                        }
                        else if(meter.MeterState == 2)
                        {
                            meterstate = "Armed";
                        }

                        Console.WriteLine("The current state of the meter " + serialnum + " is: " + meterstate);
                        Console.WriteLine("\r\nFor Disconnected, this value will always be 0");
                        Console.WriteLine("For Connected, this value will always be 1");
                        Console.WriteLine("For Armed, this value will always be 2");
                        Console.Write("\r\nInsert a new Meter State: ");
                        meter.MeterState = Convert.ToInt32(Console.ReadLine());
           
                        if (meter.MeterState == 0)
                        {
                            Console.WriteLine("\r\nState register: Disconnected!");
                        }
                        else if(meter.MeterState == 1)
                        {
                            Console.WriteLine("\r\nState register: Connected!");
                        }

                        else if(meter.MeterState == 2)
                        {
                            Console.WriteLine("\r\nState register: Armed!");
                        }
                        else
                        {
                            Console.WriteLine("\r\nInvalid Meter State!");
                            return;
                        }

                    }    
                }
            }
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