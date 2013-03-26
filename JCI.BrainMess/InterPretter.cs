using System;


namespace JCI.BrainMess
{

    public static class InterPretter
    {

        public const int TapeSize = 800;
        public static int[] tape = new int[TapeSize];
        public static int pointerIndex = 0; //Current Index of Tape
        public static int pointerValue = 0; //Value at Current Index of Tape

        public static int indexOfOpeningBracket = 0;
        public static int pointerIndexAtOpeningBracket = 0;
        public static int charIndex = 0;
        public static string outputString = string.Empty;

        public static void Interpret(string inputString)
        {
            for (charIndex = 0; charIndex < inputString.Length; charIndex++)
                switch (inputString[charIndex].ToString())
                {
                    case ">":
                        MoveToNextIndex();
                        break;
                    case "<":
                        MoveToPreviousIndex();
                        break;
                    case "+":
                        IncreaseIndexValue();
                        break;
                    case "-":
                        DecreaseIndexValue();
                        break;
                    case ".":
                        WriteIndexValue();
                        break;
                    case ",":
                        ReadIndexValue();
                        break;
                    case "[":
                        StartLoop();
                        break;
                    case "]":
                        EndLoop();
                        break;
                }
        }



        public static void IncreaseIndexValue()
        {
            ++tape[pointerIndex];
        }

        public static void DecreaseIndexValue()
        {
            --tape[pointerIndex];
        }
        public static void MoveToPreviousIndex()
        {
            --pointerIndex;
        }

        public static void MoveToNextIndex()
        {
            ++pointerIndex;
        }

        public static void StartLoop()
        {
            pointerIndexAtOpeningBracket = pointerIndex;
            indexOfOpeningBracket = charIndex;
        }
        public static void EndLoop()
        {
            if (tape[pointerIndexAtOpeningBracket] > 0)
                charIndex = indexOfOpeningBracket;
        }

        public static void WriteIndexValue()
        {
            Console.Write(Convert.ToChar((tape[pointerIndex])));
            outputString += Convert.ToChar((tape[pointerIndex]));
        }
        public static void ReadIndexValue()
        {
            tape[pointerIndex] = (int)Console.ReadKey().KeyChar;
        }
        
    }
}
