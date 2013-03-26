using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace JCI.BrainMess.Test
{
    [TestClass]
    public class UnitTest
    {
        private InterPretter objInterPretter;
         
        [TestMethod]
        public void SetUpReady()
        {
            Assert.AreEqual(1,1);
        }

        [TestMethod]
        public void TestHelloWorld()
        {
            objInterPretter = new InterPretter();
            string inputString = TestStrings.input1;
            objInterPretter.Interpret(inputString);
            string expectedResult = TestStrings.expectedResult1;
            string actualResule = objInterPretter.outputString;
            Assert.AreEqual(expectedResult,actualResule);
        }

        [TestMethod]
        public void TestHelloWorldExtended()
        {
            objInterPretter = new InterPretter();
            string inputString = TestStrings.input2;
            objInterPretter.Interpret(inputString);
            string expectedResult = TestStrings.expectedResult2;
            string actualResule = objInterPretter.outputString;
            Assert.AreEqual(expectedResult,actualResule);
        }

        [TestMethod]
        public void TestIncreaseIndexValue()
        {
            objInterPretter = new InterPretter();
            objInterPretter.IncreaseIndexValue();
            Assert.AreEqual(1, objInterPretter.tape[objInterPretter.pointerIndex]);
        }

        [TestMethod]
        public void TestIncreaseIndexValueViaInterpret()
        {
            objInterPretter = new InterPretter();
            objInterPretter.Interpret("+");
            Assert.AreEqual(1,objInterPretter.tape[objInterPretter.pointerIndex]);
        }

        
        [TestMethod]
        public void TestDecreaseIndexValue()
        {
            objInterPretter = new InterPretter();
            objInterPretter.DecreaseIndexValue();
            Assert.AreEqual(-1, objInterPretter.tape[objInterPretter.pointerIndex]);
        }
        
        [TestMethod]
        public void TestDecreaseIndexValueViaInterpret()
        {
            objInterPretter = new InterPretter();
            objInterPretter.Interpret("-");
            Assert.AreEqual(-1, objInterPretter.tape[objInterPretter.pointerIndex]);
        }

        [TestMethod]
        public void TestMoveToNextIndex()
        {
            objInterPretter = new InterPretter();
            objInterPretter.MoveToNextIndex();
            Assert.AreEqual(1, objInterPretter.pointerIndex);
        }
        
        [TestMethod]
        public void TestMoveToNextIndexViaInterpret()
        {
            objInterPretter = new InterPretter();
            objInterPretter.Interpret(">");
            Assert.AreEqual(1, objInterPretter.pointerIndex);
        }

        [TestMethod]
        public void TestMoveToPreviousIndex()
        {
            objInterPretter = new InterPretter();
            objInterPretter.MoveToNextIndex();
            objInterPretter.MoveToPreviousIndex();
            Assert.AreEqual(0, objInterPretter.pointerIndex);
        }
        
        [TestMethod]
        public void TestMoveToPreviousIndexViaInterpret()
        {
            objInterPretter = new InterPretter();
            objInterPretter.Interpret("><");
            Assert.AreEqual(0, objInterPretter.pointerIndex);
        }
        

        #region ---------------Negative Testing--------------------------------
        
        [TestMethod]
        public void TestInputEmpty()
        {
            objInterPretter = new InterPretter();
            objInterPretter.Interpret(TestStrings.negativeInput1);
            Assert.AreEqual(0, objInterPretter.pointerIndex);
        }
        
        [TestMethod]
        public void TestInputSpace()
        {
            objInterPretter = new InterPretter();
            objInterPretter.Interpret(TestStrings.negativeInput2);
            Assert.AreEqual(0, objInterPretter.pointerIndex);
        }

        [TestMethod]
        public void TestNoMove()
        {
            objInterPretter = new InterPretter();
            objInterPretter.Interpret(TestStrings.negativeInput3);
            Assert.AreEqual(0, objInterPretter.tape[objInterPretter.pointerIndex]);
            Assert.AreEqual(0, objInterPretter.pointerIndex);

        }
        [TestMethod]
        public void TestInputInvalid()
        {
            objInterPretter = new InterPretter();
            objInterPretter.Interpret(TestStrings.negativeInput4);
            Assert.AreEqual(0, objInterPretter.tape[objInterPretter.pointerIndex]);
        }

        #endregion ---------------------------------------------------------------
    }

    

}
