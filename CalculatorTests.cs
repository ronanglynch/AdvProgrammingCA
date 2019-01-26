using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VectorLibrary;



namespace VectorLibraryTests
{



    /*
     * Attributes are used to identify classes and functions
     * that are part of unit testing.
     * The [TestClass] attribute is required by the framework so that the Test
     * Explorer can identify those classes that potentially have
     * test methods defined.
     */

    [TestClass]
    public class CalculatorTests
    {

        /*

        */

        [TestMethod]
        public void AbsNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num10 = new Calculator(10);
            Calculator num100 = new Calculator(100);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus2 = new Calculator(-2);

            double sumABS0 = Calculator.abs(num0);
            double sumABS10 = Calculator.abs(num10);
            double sumABS100 = Calculator.abs(num100);
            double numABSMinus1 = Calculator.abs(numMinus1);
            double numABSMinus2 = Calculator.abs(numMinus2);

            Assert.AreEqual(0, sumABS0);
            Assert.AreEqual(10, sumABS10);
            Assert.AreEqual(100, sumABS100);
            Assert.AreEqual(1, numABSMinus1);
            Assert.AreEqual(2, numABSMinus2);


        }



        [TestMethod]
        public void AddingNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num10 = new Calculator(10);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus10 = new Calculator(-10);


            double sum5 = num0 + num5;
            double sum9 = num4 + num5;
            double sum0 = num10 + numMinus10;
            double sumMinus1 = num0 + numMinus1;

            Assert.AreEqual(5, sum5);
            Assert.AreEqual(9, sum9);
            Assert.AreEqual(0, sum0);
            Assert.AreEqual(-1, sumMinus1);

        }




        [TestMethod]
        public void DivisionNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num10 = new Calculator(10);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus10 = new Calculator(-10);


            double sum0 = num5 / num0;
            double sum2 = num10 / num5;
            double sumMinus1 = num10 / numMinus10;
            double sumMinus_ZeroPoint1 = numMinus1 / num10;
            double sum1 = numMinus1 / numMinus10;

            Assert.AreEqual(0, sum0);
            Assert.AreEqual(2, sum2);
            Assert.AreEqual(-1, sumMinus1);
            Assert.AreEqual(-0.1, Math.Round(sumMinus_ZeroPoint1, 5));
            Assert.AreEqual(0.1, Math.Round(sum1, 5));

        }



        [TestMethod]
        public void ExponentialNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num9 = new Calculator(9);
            Calculator num100 = new Calculator(100);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus2 = new Calculator(-2);

            double sumEXP0 = Calculator.exp(num0);
            double sumEXP4 = Calculator.exp(num4);
            double sumEXP9 = Calculator.exp(num9);
            double numEXPMinus1 = Calculator.exp(numMinus1);
            double numEXPMinus2 = Calculator.exp(numMinus2);

            Assert.AreEqual(1, sumEXP0);
            Assert.AreEqual(54.59815, Math.Round(sumEXP4,5));
            Assert.AreEqual(8103.08393, Math.Round(sumEXP9,5));
            Assert.AreEqual(0.36788, Math.Round(numEXPMinus1,5));
            Assert.AreEqual(0.13534, Math.Round(numEXPMinus2,5));

        }




        [TestMethod]
        public void LogNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num10 = new Calculator(10);
            Calculator num100 = new Calculator(100);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus2 = new Calculator(-2);

            double sumLog0 = Calculator.log(num0);
            double sumLog10 = Calculator.log(num10);
            double sumLog100 = Calculator.log(num100);
            double numLogMinus1 = Calculator.log(numMinus1);
            double numLogMinus2 = Calculator.log(numMinus2);

            Assert.AreEqual(0, sumLog0);
            Assert.AreEqual(1, sumLog10);
            Assert.AreEqual(2,sumLog100);
            Assert.AreEqual(0, numLogMinus1);
            Assert.AreEqual(0, numLogMinus2);
            Assert.AreEqual(0, numLogMinus2);


        }



        [TestMethod]
        public void ModulusNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num9 = new Calculator(9);
            Calculator num10 = new Calculator(10);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus10 = new Calculator(-10);


            double sum0Mod0 = num0 % num0;
            double sum4Mod0 = num4 % num0;
            double sum10Mod5 = num10 % num5;
            double sum10ModMinus10 = num10 % numMinus10;
            double sumMinus1_Mod_10 = numMinus1 % num10;
            double sumMinus1_Mod_Minus10 = numMinus1 % numMinus10;
            double sum9_Mod_5 = num9 % num5;

            Assert.AreEqual(0, sum0Mod0);
            Assert.AreEqual(0, sum4Mod0);
            Assert.AreEqual(0, sum10Mod5);
            Assert.AreEqual(0, sum10ModMinus10);
            Assert.AreEqual(-1, sumMinus1_Mod_10);
            Assert.AreEqual(4, sum9_Mod_5);

        }





        [TestMethod]
        public void MultiplyNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num10 = new Calculator(10);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus10 = new Calculator(-10);


            double sum0 = num0 * num5;
            double sum20 = num4 * num5;
            double sumMinus100 = num10 * numMinus10;
            double sumMinus10 = numMinus1 * num10;
            double sum10 = numMinus1 * numMinus10;

            Assert.AreEqual(0, sum0);
            Assert.AreEqual(20, sum20);
            Assert.AreEqual(-100, sumMinus100);
            Assert.AreEqual(-10, sumMinus10);
            Assert.AreEqual(10, sum10);

        }




        [TestMethod]
        public void PowersNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num2 = new Calculator(2);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num10 = new Calculator(10);
            Calculator num100 = new Calculator(100);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus2 = new Calculator(-2);
            Calculator numMinus10 = new Calculator(-10);
            Calculator numMinus100 = new Calculator(-100);


            double sum0Power0 = num0 ^ num0;
            double sum0PowerMinus100 = num0 ^ numMinus100;
            double sum4Power0 = num4 ^ num0;
            double sumMinus10Power0 = numMinus10 ^ num0;
            double sum10Power5 = num10 ^ num5;
            double sum10PowerMinus1 = num10 ^ numMinus1;
            double sumMinus1Power10 = numMinus1 ^ num10;
            double sumMinus1PowerMinus10 = numMinus1 ^ numMinus10;
            double sumMinus10PowerMinus2 = numMinus10 ^ numMinus2;


            Assert.AreEqual(0, sum0Power0);
            Assert.AreEqual(0, sum0PowerMinus100);
            Assert.AreEqual(1, sum4Power0);
            Assert.AreEqual(1, sumMinus10Power0);
            Assert.AreEqual(100000, sum10Power5);
            Assert.AreEqual(0.1, sum10PowerMinus1);
            Assert.AreEqual(1, sumMinus1Power10);
            Assert.AreEqual(1, sumMinus1PowerMinus10);
           Assert.AreEqual(0.01, sumMinus10PowerMinus2);

        }




        [TestMethod]
        public void SquareRootNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num9 = new Calculator(9);
            Calculator num100 = new Calculator(100);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus100 = new Calculator(-100);

            double sumSQRT0 = Calculator.sqrt(num0);
            double sumSQRT4 = Calculator.sqrt(num4);
            double sumSQRT9 = Calculator.sqrt(num9);
            double sumSQRT100 = Calculator.sqrt(num100);
            double numSQRTMinus1 = Calculator.sqrt(numMinus1);
            double numSQRTMinus100 = Calculator.sqrt(numMinus100);

            Assert.AreEqual(0, sumSQRT0);
            Assert.AreEqual(2, sumSQRT4);
            Assert.AreEqual(3, sumSQRT9);
            Assert.AreEqual(10, sumSQRT100);
            Assert.AreEqual(0, numSQRTMinus1);
            Assert.AreEqual(0, numSQRTMinus100);

        }

        

        [TestMethod]
        public void SubractNumbers()
        {
            Calculator num0 = new Calculator(0);
            Calculator num4 = new Calculator(4);
            Calculator num5 = new Calculator(5);
            Calculator num10 = new Calculator(10);
            Calculator numMinus1 = new Calculator(-1);
            Calculator numMinus10 = new Calculator(-10);


            double sumMinus5 = num0 - num5;
            double sumMinus1 = num4 - num5;
            double sum20 = num10 - numMinus10;
            double sumMinus11 = numMinus1 - num10;
            double sum9 = numMinus1 - numMinus10;

            Assert.AreEqual(-5, sumMinus5);
            Assert.AreEqual(-1, sumMinus1);
            Assert.AreEqual(20, sum20);
            Assert.AreEqual(-11, sumMinus11);
            Assert.AreEqual(9, sum9);

        }
                                    

    }
}
