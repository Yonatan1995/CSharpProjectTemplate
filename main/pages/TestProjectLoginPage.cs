using CSharpProjectTemplate.main.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.pages
{
    /**
    * This is an Example for Page Object class.
    */
    class TestProjectLoginPage : BasePage
    {

        public TestProjectLoginPage(IWebDriver driver) :base(driver)
        {
            this.driver = driver;
        }

        // Elements Locators.
        private By username = By.XPath(PropertyReader.readElementsRepoItem("tp_user_name_input_xpath"));
        private By password = By.XPath(PropertyReader.readElementsRepoItem("tp_password_input_xpath"));
        private By loginButton = By.XPath(PropertyReader.readElementsRepoItem("tp_login_button_xpath"));
        private By logoutButton = By.XPath(PropertyReader.readElementsRepoItem("tp_logout_button_xpath"));

        /**
         * This method return the username input element.
         *
         * @return WebElement.
         */
        public IWebElement getUserNameElement()
        {
            return driver.FindElement(username);
        }

        /**
         * This method return the password input element.
         *
         * @return WebElement.
         */
        public IWebElement getPasswordElement()
        {
            return driver.FindElement(password);
        }

        /**
         * This method return the login button element.
         *
         * @return WebElement.
         */
        public IWebElement getLoginBtnElement()
        {
            return driver.FindElement(loginButton);
        }

        /**
         * This method return the logout button element.
         *
         * @return WebElement.
         */
        public IWebElement getLogOutBtnElement()
        {
            return driver.FindElement(logoutButton);
        }

    }
}
