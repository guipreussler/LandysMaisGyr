using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool allDone;
            allDone = false;

            Meter meter = new Meter();

            List<Meter> list_meter = new List<Meter>();

            while(!allDone)
            {
                Console.WriteLine("====================== MENU =======================\r\n");
                Console.WriteLine("Select an item from the list:");
                Console.WriteLine("1) Insert a new endpoint");
                Console.WriteLine("2) Edit an existing endpoint");
                Console.WriteLine("3) Delete an existing endpoint");
                Console.WriteLine("4) List all endpoints");
                Console.WriteLine("5) Find a endpoint by 'Endpoint Serial Number'");
                Console.WriteLine("6) Exit");
                Console.Write("===================================================[ ");
                
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());

                    switch(number)
                    {

                        case 1:                       
                            meter = Inserir1.Renderizar1();
                        
                            if(meter != null)
                            {
                                list_meter.Add(meter);
                                meter = new Meter();
                            }
                        
                        break;

                        case 2:  
                            Editar2.Renderizar2(list_meter);
                        
                        break;

                        case 3:     
                            Excluir3.Renderizar3(list_meter);
                        break;

                        case 4:    
                            Listar4.Renderizar4(list_meter);
                        break;

                        case 5:   
                            Encontrar5.Renderizar5(list_meter);
                        break;

                        case 6: 

                            char confirm;

                            Console.WriteLine("Do you wish to close the application? (y/n)");
                            confirm = Convert.ToChar(Console.ReadLine());

                            switch(confirm)
                            {

                                case 'y':
                                    Console.WriteLine("\r\nClosing application! :)\r\n");
                                    allDone = true;
                                break;

                                case 'n':
                            
                                break;
                            }
                    

                        break;

                    }
                }
                catch
                {
                    Console.WriteLine("\r\nInvalid Number!");
                }
            }
        }

    }
}
