using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //what data types have we talked about so far!
            char firstInitial = 'o';
            //characters or chars are sinle or numbers or symbols

            bool isTired = true;
            //boolean or bool is true or false.

            //other number Data types
            float number = 2.4647547382466f;
            decimal partialNum = 2.18383774744774m;
            double someNumber = 2.123444455;

            //Relational Operands
            //now lets talk about operators!
            // + adds two operands
            // - subtracts
            //* multiply
            // / divides operand
            // % modulus
            // ++ Increments operator by one
            // -- decrement decreases value 
            // == checks 

            int jarrydage = 29;
            int danielage = 32;
            Console.WriteLine(jarrydage == danielage);

            Console.WriteLine(number);
            Console.WriteLine(partialNum);
            Console.WriteLine(someNumber);

            /*
            > checks if the left operand is greater than the right

            < checks if the operand on the left is less than the operand on the left.

            >= greater to or equal

            <= less than or equal.

            */
        }
    }
}
