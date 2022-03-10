using CSharpProjectTemplate.main.Base;
using CSharpProjectTemplate.main.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.pages
{
    /**
     * This is an Example for Page Object class.
     */
    class MobileLoginPage:BasePage
    {
        public MobileLoginPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }

        // Elements Locators.
        private By username = By.XPath(ElementsRepoConstants.eri_username_xpath);
        private By password = By.XPath(ElementsRepoConstants.eri_password_xpath);
        private By loginButton = By.XPath(ElementsRepoConstants.eri_login_button_xpath);
        private By logoutButton = By.XPath(ElementsRepoConstants.eri_logout_button_xpath);

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
        public IWebElement getLoginButton()
        {
            return driver.FindElement(loginButton);
        }

        /**
         * This method return the logout button element.
         *
         * @return WebElement.
         */
        public IWebElement getLogoutButton()
        {
            return driver.FindElement(logoutButton);
        }

    }
}
