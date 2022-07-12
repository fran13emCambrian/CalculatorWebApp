using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLogic;

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Addition

        //Test 1
        [TestMethod]
        public void AdditionUnitTestCheck1()
        {
            double num1 = 0;
            double num2 = 0;
            double desired = 0;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 2
        [TestMethod]
        public void AdditionUnitTestCheck2()
        {
            double num1 = 7;
            double num2 = 3;
            double desired = 10;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 3
        [TestMethod]
        public void AdditionUnitTestCheck3()
        {
            double num1 = 15;
            double num2 = 14;
            double desired = 29;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 4
        [TestMethod]
        public void AdditionUnitTestCheck4()
        {
            double num1 = 23;
            double num2 = 11;
            double desired = 34;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 5
        [TestMethod]
        public void AdditionUnitTestCheck5()
        {
            double num1 = 33;
            double num2 = 9;
            double desired = 42;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 6
        [TestMethod]
        public void AdditionUnitTestCheck6()
        {
            double num1 = 17;
            double num2 = 11;
            double desired = 28;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 7
        [TestMethod]
        public void AdditionUnitTestCheck7()
        {
            double num1 = 53;
            double num2 = 7;
            double desired = 60;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 8
        [TestMethod]
        public void AdditionUnitTestCheck8()
        {
            double num1 = 61;
            double num2 = 3;
            double desired = 64;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 9
        [TestMethod]
        public void AdditionUnitTestCheck9()
        {
            double num1 = 77;
            double num2 = 5;
            double desired = 82;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 10
        [TestMethod]
        public void AdditionUnitTestCheck10()
        {
            double num1 = 88;
            double num2 = 11;
            double desired = 99;

            double actualResult = Class1.Addition(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }



        //Substraction

        //Test 1
        [TestMethod]
        public void SubtractionUnitTestCheck1()
        {
            double num1 = 7;
            double num2 = 4;
            double desired = 3;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 2
        [TestMethod]
        public void SubtractionUnitTestCheck2()
        {
            double num1 = 11;
            double num2 = 3;
            double desired = 8;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 3
        [TestMethod]
        public void SubtractionUnitTestCheck3()
        {
            double num1 = 15;
            double num2 = 4;
            double desired = 11;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 4
        [TestMethod]
        public void SubtractionUnitTestCheck4()
        {
            double num1 = 23;
            double num2 = 11;
            double desired = 12;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 5
        [TestMethod]
        public void SubtractionUnitTestCheck5()
        {
            double num1 = 33;
            double num2 = 9;
            double desired = 24;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 6
        [TestMethod]
        public void SubtractionUnitTestCheck6()
        {
            double num1 = 17;
            double num2 = 11;
            double desired = 6;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 7
        [TestMethod]
        public void SubtractionUnitTestCheck7()
        {
            double num1 = 53;
            double num2 = 7;
            double desired = 46;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 8
        [TestMethod]
        public void SubtractionUnitTestCheck8()
        {
            double num1 = 61;
            double num2 = 3;
            double desired = 58;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 9
        [TestMethod]
        public void SubtractionUnitTestCheck9()
        {
            double num1 = 77;
            double num2 = 5;
            double desired = 72;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 10
        [TestMethod]
        public void SubtractionUnitTestCheck10()
        {
            double num1 = 88;
            double num2 = 11;
            double desired = 77;

            double actualResult = Class1.Subtraction(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }


        //Multiplication

        //Test 1
        [TestMethod]
        public void MultiplicationUnitTestCheck1()
        {
            double num1 = 7;
            double num2 = 4;
            double desired = 28;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 2
        [TestMethod]
        public void MultiplicationUnitTestCheck2()
        {
            double num1 = 11;
            double num2 = 3;
            double desired = 33;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 3
        [TestMethod]
        public void MultiplicationUnitTestCheck3()
        {
            double num1 = 15;
            double num2 = 4;
            double desired = 60;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 4
        [TestMethod]
        public void MultiplicationUnitTestCheck4()
        {
            double num1 = 23;
            double num2 = 11;
            double desired = 253;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 5
        [TestMethod]
        public void MultiplicationUnitTestCheck5()
        {
            double num1 = 33;
            double num2 = 9;
            double desired = 297;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 6
        [TestMethod]
        public void MultiplicationUnitTestCheck6()
        {
            double num1 = 17;
            double num2 = 11;
            double desired = 187;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 7
        [TestMethod]
        public void MultiplicationUnitTestCheck7()
        {
            double num1 = 53;
            double num2 = 7;
            double desired = 371;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 8
        [TestMethod]
        public void MultiplicationUnitTestCheck8()
        {
            double num1 = 61;
            double num2 = 3;
            double desired = 183;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 9
        [TestMethod]
        public void MultiplicationUnitTestCheck9()
        {
            double num1 = 77;
            double num2 = 5;
            double desired = 385;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 10
        [TestMethod]
        public void MultiplicationUnitTestCheck10()
        {
            double num1 = 88;
            double num2 = 11;
            double desired = 968;

            double actualResult = Class1.Multiplication(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }


        //Division

        //Test 1
        [TestMethod]
        public void DivisionUnitTestCheck1()
        {
            double num1 = 8;
            double num2 = 4;
            double desired = 2;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 2
        [TestMethod]
        public void DivisionUnitTestCheck2()
        {
            double num1 = 12;
            double num2 = 3;
            double desired = 4;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 3
        [TestMethod]
        public void DivisionUnitTestCheck3()
        {
            double num1 = 16;
            double num2 = 4;
            double desired = 4;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 4
        [TestMethod]
        public void DivisionUnitTestCheck4()
        {
            double num1 = 22;
            double num2 = 11;
            double desired = 2;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 5
        [TestMethod]
        public void DivisionUnitTestCheck5()
        {
            double num1 = 45;
            double num2 = 9;
            double desired = 5;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 6
        [TestMethod]
        public void DivisionUnitTestCheck6()
        {
            double num1 = 77;
            double num2 = 11;
            double desired = 7;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 7
        [TestMethod]
        public void DivisionUnitTestCheck7()
        {
            double num1 = 56;
            double num2 = 7;
            double desired = 8;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 8
        [TestMethod]
        public void DivisionUnitTestCheck8()
        {
            double num1 = 8;
            double num2 = 8;
            double desired = 1;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 9
        [TestMethod]
        public void DivisionUnitTestCheck9()
        {
            double num1 = 100;
            double num2 = 10;
            double desired = 10;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }

        //Test 10
        [TestMethod]
        public void DivisionUnitTestCheck10()
        {
            double num1 = 88;
            double num2 = 8;
            double desired = 11;

            double actualResult = Class1.Division(num1, num2);

            Assert.AreEqual(desired, actualResult);
        }


    }
}
