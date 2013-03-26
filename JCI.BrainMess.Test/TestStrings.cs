
namespace JCI.BrainMess.Test
{
    public struct TestStrings
    {
        public static string input1 = "++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.>.";
        public static string input2 = "++++++++++[>+++++++>++++++++++>+++>+<<<<-]>++.>+.+++++++..+++.>++.<<+++++++++++++++.>.+++.------.--------.>+.";
        public static string expectedResult1 = "Hello World!\n";
        public static string expectedResult2 = "Hello World!";

        public static string negativeInput1 = "";
        public static string negativeInput2 = " ";
        public static string negativeInput3 = ".";
        public static string negativeInput4 = "23 4_23dsfgsgdfgdgqtqrter!!!!@@#$%^&*()";
    }
}
