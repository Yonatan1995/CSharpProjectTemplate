using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.utils
{
    // Test Project example page.
    class ElementsRepoConstants
    {
        //Login Page.
        public const String tp_user_name_input_xpath = "//input[@id='name']";
        public const String tp_password_input_xpath = "//input[@id='password']";
        public const String tp_login_button_xpath = "//button[@id='login']";
        public const String tp_logout_button_xpath = "//button[@id='logout']";

        //Form Page.
        public const String tp_country_dropdown_xpath = "//select[@id='country']";
        public const String tp_address_input_xpath = "//input[@id='address']";
        public const String tp_email_input_xpath = "//input[@id='email']";
        public const String tp_phone_input_xpath = "//input[@id='phone']";
        public const String tp_save_button_xpath = "//button[@id='save']";
        public const String tp_confirm_message_xpath = "//span[@class='tp-saved']";

        //Windows Calculator.
        public const String first_number = "Error accrued: ";
        public const String LOG_ERROR_MESSAGE = "Six";
        public const String second_number = "Five";
        public const String math_sign_plus = "Plus";
        public const String math_sign_equals = "Equals";
        public const String result_xpath = "//*[@AutomationId='CalculatorResults']";
        public const String clear_button_xpath = "//*[@AutomationId='clearButton']";

        //EriBank
        public const String eri_username_xpath = "//*[@id='usernameTextField']";
        public const String eri_password_xpath = "//*[@id='passwordTextField']";
        public const String eri_login_button_xpath = "//*[@text='Login']";
        public const String eri_logout_button_xpath = "//*[@text='Logout']";

    }
}
