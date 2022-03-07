using CSharpProjectTemplate.main.utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.test.Base
{
    /**
    * Base class for over test classes.
    * Test classes should extend this class.
    */
    class TestBase:DriverManager
    {
        /**
        * This is a setup method that runs before each test class and used to call initDriver method of DriverManager.
        */
        [SetUp]
        public void setUp()
        {
            //Log.info("Setting up driver");
            initDriver();
            new WaitForHelper(driver).implicitWait();
        }
        [Test]
        public static void fun()
        {
            Console.Write("hello");
        }
        /**
         * This method is a teardown method used to quit driver after each test class.
         */
        [TearDown]
        public void tearDown()
        {
            // Log.info("Closing driver");
            //driver.Close();
            driver.Quit();
        }
    }
}
