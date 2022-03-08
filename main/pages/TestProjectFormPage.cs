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
    class TestProjectFormPage:BasePage
    {
        public TestProjectFormPage(IWebDriver driver):base(driver)
        {
            this.driver = driver;
        }

        // Elements Locators.
        //private By countries = By.XPath(PropertyReader.readElementsRepoItem("tp_country_dropdown_xpath"));
        //private By address = By.XPath(PropertyReader.readElementsRepoItem("tp_address_input_xpath"));
        //private By email = By.XPath(PropertyReader.readElementsRepoItem("tp_email_input_xpath"));
        //private By phone = By.XPath(PropertyReader.readElementsRepoItem("tp_phone_input_xpath"));
        //private By saveButton = By.XPath(PropertyReader.readElementsRepoItem("tp_save_button_xpath"));
        //private By confirmMessage = By.XPath(PropertyReader.readElementsRepoItem("tp_confirm_message_xpath"));
        private By countries = By.XPath(ElementsRepoConstants.tp_country_dropdown_xpath);
        private By address = By.XPath(ElementsRepoConstants.tp_address_input_xpath);
        private By email = By.XPath(ElementsRepoConstants.tp_email_input_xpath);
        private By phone = By.XPath(ElementsRepoConstants.tp_phone_input_xpath);
        private By saveButton = By.XPath(ElementsRepoConstants.tp_save_button_xpath);
        private By confirmMessage = By.XPath(ElementsRepoConstants.tp_confirm_message_xpath);


        /**
         * This method return the country input element.
         *
         * @return WebElement
         */
        public IWebElement getCountries()
        {
            return driver.FindElement(countries);
        }

        /**
         * This method return the address input element.
         *
         * @return WebElement
         */
        public IWebElement getAddressElement()
        {
            return driver.FindElement(address);
        }

        /**
         * This method return the email input element.
         *
         * @return WebElement
         */
        public IWebElement getEmailElement()
        {
            return driver.FindElement(email);
        }

        /**
         * This method return the phone input element.
         *
         * @return WebElement
         */
        public IWebElement getPhoneElement()
        {
            return driver.FindElement(phone);
        }

        /**
         * This method return the saveButton button element.
         *
         * @return WebElement
         */
        public IWebElement getSaveButtonElement()
        {
            return driver.FindElement(saveButton);
        }

        /**
         * This method return the confirmMessage element.
         *
         * @return WebElement
         */
        public IWebElement getConfirmMessageElement()
        {
            return driver.FindElement(confirmMessage);
        }
    }
}
