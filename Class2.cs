using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_first_step_forward
{
    internal class Class2
    {
        static void Main(String[] args)
        {

            int f= 0, c= 0;

           
            
            Console.WriteLine("Hello,welcome to my Converter Calculator");
            Console.WriteLine("{0,-11}{1,1}{2,-11}", "Degree C", "|" , "Degree F");
            Console.WriteLine("{0,-11}{1,1}{2,-11}", "...........","|", ".............");
            for(c=0; c<=100; c+= 5){

                f = c * 9 / 5 + 32;

                Console.WriteLine("{0, -11}{1,1}{2,-11}", c, "|" , f);

            }

        } 
    }
}
