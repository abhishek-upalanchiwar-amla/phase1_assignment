using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpfirst
{
    class AllProgram
    {
        public static void Main()
        {
            //bool isRunning = false;
            Console.WriteLine("1.Enter 1 to perform Operation");
          //  Console.WriteLine("2.Enter 2 to print");
            int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Program program = new Program();
                            program.Abhishek();
                            break;
                        }
                    case 2:
                        {
                            Progtrasharp progtrasharp = new Progtrasharp();
                            progtrasharp.Upalanchiwar();
                            break;
                        }
                    case 3:
                    {
                        lastprogram lastprogram = new lastprogram();
                        lastprogram.arun();
                        break;
                  
                    }



                default:
                        {
                            Console.WriteLine("Enter a valid Choice");
                            break;
                        }

                }
            }
        }
    }

