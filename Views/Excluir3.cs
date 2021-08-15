using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    public class Excluir3
    {

        public static void Renderizar3(List<Meter> list_meter)
        {
            string serialnum;
            char confirm;

            Console.Write("\r\nInsert an Endpoint Serial Number: ");
            serialnum = Convert.ToString(Console.ReadLine().ToUpper());
            
            Meter Meter = SearchMeter(list_meter, serialnum);

            if (Meter == null || Meter.MeterState == 3)
            {
                Console.WriteLine("\r\nMeter Not Found in the System!");
            }
            else
            {
                foreach (var meter in list_meter)
                {
                    if (meter.SerialNumber.Equals(serialnum))
                    {
                        Console.WriteLine("Do you want to delete the meter: " + serialnum +"? (y/n)");
                        confirm = Convert.ToChar(Console.ReadLine());

                        switch(confirm)
                        {
                        case 'y':
            
                        //list_meter.RemoveAt(list_meter);
                        //list_meter.RemoveAll(x => x.meter.SerialNumber);
                        //list_meter.Remove(list_meter.Meter);

                        //Tentei usar os métodos de Remove com Lambda, porém estavam dando erro
                        //E não removiam o item da lista, sendo assim fiz uma "Gambiarra" para não apagar o item,
                        //Mas obstruir a visualização dele nas listas .

                            meter.MeterState = 3;
                            Console.WriteLine("\r\nItem removed from list successfully!");
                        break;

                        case 'n':
                            Console.WriteLine("\r\nItem not removed from the list!");
                        break;
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