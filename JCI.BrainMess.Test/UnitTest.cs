using JCI.BrainMess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JCI.BrainMess.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void SetUpReady()
        {
            Assert.AreEqual(1,1);
        }

        [TestMethod]
        public void TestMethod1()
        {
            string inputString = InputStrings.input1;
           //   
            InterPretter.Interpret(inputString);
            string expectedResult = "Hello World!\n";
            string actualResule = InterPretter.outputString;
            Assert.AreEqual(expectedResult,actualResule);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string inputString = InputStrings.input2;
           //   
            InterPretter.Interpret(inputString);
            string expectedResult = "Hello World!";
            string actualResule = InterPretter.outputString;
            Assert.AreEqual(expectedResult,actualResule);
        }

        [TestMethod]
        public void TestMethod31()
        {
            InterPretter.Interpret("+");
            Assert.AreEqual(1,InterPretter.tape[InterPretter.pointerIndex]);
        }

        [TestMethod]
        public void TestMethod32()
        {
            InterPretter.IncreaseIndexValue();
            Assert.AreEqual(1, InterPretter.tape[InterPretter.pointerIndex]);
        }
        [TestMethod]
        public void TestMethod41()
        {
            InterPretter.Interpret("-");
            Assert.AreEqual(-1, InterPretter.tape[InterPretter.pointerIndex]);
        }

        [TestMethod]
        public void TestMethod42()
        {
            InterPretter.DecreaseIndexValue();
            Assert.AreEqual(-1, InterPretter.tape[InterPretter.pointerIndex]);
        }
        [TestMethod]
        public void TestMethod51()
        {
            InterPretter.Interpret(">");
            Assert.AreEqual(1, InterPretter.pointerIndex);
        }

        [TestMethod]
        public void TestMethod52()
        {
            InterPretter.MoveToNextIndex();
            Assert.AreEqual(1, InterPretter.pointerIndex);
        }

        [TestMethod]
        public void TestMethod61()
        {
            InterPretter.Interpret("><");
            Assert.AreEqual(0, InterPretter.pointerIndex);
        }

        [TestMethod]
        public void TestMethod62()
        {
            InterPretter.MoveToNextIndex();
            InterPretter.MoveToPreviousIndex();
            Assert.AreEqual(0, InterPretter.pointerIndex);
        }


    }
}
