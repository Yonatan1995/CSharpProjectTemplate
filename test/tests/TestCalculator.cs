using CSharpProjectTemplate.main.bussinessProcess;
using CSharpProjectTemplate.main.utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.test.tests
{
    /**
    * This is Windows Applications example test.
     */
    class TestCalculator
    {
        /**
        * This is an addition example test using windows calculator.
         */
        //@Test(description = "Addition test.")
        [Test]
        public void additionTest()
        {
            Logger.startTestCase("additionTest");
            String result = CalculatorExample.performAddition();
            Assert.AreEqual(result, Constants.EXPECTED_CALC_RESULT);
            Logger.endTestCase("additionTest");
        }
    }
}
