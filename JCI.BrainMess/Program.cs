﻿using System;


namespace JCI.BrainMess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter input string, \nIf you do not enter anything then default value will be picked....");
            string inputString = Console.ReadLine();
            if (inputString == "")
                inputString = "++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.";
           
            InterPretter objInterPretter = new InterPretter();
            objInterPretter.Interpret(inputString);
            
            Console.ReadLine();
        }
    }

}
