using System;
using System.Collections.Generic;
using ListaExercicio.Models;

namespace ListaExercicio.Views  
{                               
    public class Inserir1
    {
        public static Meter Renderizar1()
        {
        
            Meter meter = new Meter();

        //Serial Number   
            Console.Write("\r\nInsert an Endpoint Serial Number: ");
            meter.SerialNumber = Convert.ToString(Console.ReadLine().ToUpper());

            if(meter.SerialNumber.Equals("NSX1P2W")){

                meter.MeterId = 16;
                Console.WriteLine("\r\nThe Meter's Model ID is " + meter.MeterId);
            }
            
            else if (meter.SerialNumber.Equals("NSX1P3W")){

                meter.MeterId = 17;
                Console.WriteLine("\r\nThe Meter's Model ID is " + meter.MeterId);
            }

            else if (meter.SerialNumber.Equals("NSX2P3W")){

                meter.MeterId = 18;
                Console.WriteLine("\r\nThe Meter's Model ID is " + meter.MeterId);
            }

            else if (meter.SerialNumber.Equals("NSX3P4W")){

                meter.MeterId = 19;
                Console.WriteLine("\r\nThe Meter's Model ID is " + meter.MeterId);
            }
            else
            {
                try
                {
                    Console.Write("\r\nInsert a Meter Model ID: ");
                    meter.MeterId = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\r\nInvalid Model ID!");
                    return null;
                }
            }

        //Meter Number
            try
            {
                Console.Write("\r\nInsert a Meter Number: ");
                meter.MeterNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("\r\nInvalid Number!"); 
                return null;
            }

        //Meter Firmware Version
            Console.Write("\r\nInsert a Meter Firmware Version: ");
            meter.FirmwareVersion = Convert.ToString(Console.ReadLine());

        //Meter State
            Console.WriteLine("\r\nFor Disconnected, this value will always be 0");
            Console.WriteLine("For Connected, this value will always be 1");
            Console.WriteLine("For Armed, this value will always be 2");
        try
        {    
            Console.Write("\r\nInsert a Meter State: ");
            meter.MeterState = Convert.ToInt32(Console.ReadLine());
           
            if (meter.MeterState == 0){

                Console.WriteLine("\r\nState register: Disconnected!");
            }

            else if(meter.MeterState == 1){

                Console.WriteLine("\r\nState register: Connected!");
            }

            else if(meter.MeterState == 2){

                Console.WriteLine("\r\nState register: Armed!");
                
            }
            else
            {
                Console.WriteLine("\r\nInvalid Number!");
                return null;
            }
        }
        catch //Necessário mais um try catch pra validar não apenas números, mas letras e caracteres especiais. 
        {
            Console.WriteLine("\r\nInvalid Number!");
            return null;
        }
            Console.WriteLine("\r\nPress Enter to Return to Menu!");
            Console.ReadKey();
            return meter;
        }
    }
}