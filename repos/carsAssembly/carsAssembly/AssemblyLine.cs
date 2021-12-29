using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carsAssembly
{
    public static class AssemblyLine
    {

        public static double Succesrate(int speed)
        {
            Console.Write(" Succes rate is \n");
            if (speed >= 1 && speed < 5)
            {
                Console.WriteLine(0.10);
          
                return 0.10;
              
            }
            else if (speed >= 5 && speed < 8)
            {
                double x = 0.9;
                Console.WriteLine(0.9);
                return x;
            }
            else if (speed ==9)
            {
                double y = 0.8;
                Console.WriteLine(0.8);
                return y;
               
            }
            else if (speed == 10)
            {
                Console.WriteLine(0.77);

                return 0.77;
                
            }
            else
                Console.WriteLine(0);

            return 0;
            
        }
        public static float workingItemsPerMinute(int speed)
        {
            Console.Write(" Cars per minute:\n");

           int productionRatePerHour = 221;
            float s = (productionRatePerHour * (speed)) / 60;
            Console.WriteLine(s);

            return s;
          
        }

        public static double RatePerHour(int speed)
        {
            Console.Write(" Cars per hour:\n");
            int productionRatePerHour = 221;
            int w = (productionRatePerHour) * speed;
            Console.WriteLine(w);

            return w;
        } 
            
           
        } 
        
    }
        
    

