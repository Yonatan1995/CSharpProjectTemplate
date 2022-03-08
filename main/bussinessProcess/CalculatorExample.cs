using CSharpProjectTemplate.main.utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.bussinessProcess
{
    /**
     * This is an example business process for calculator addition test.
     */
    class CalculatorExample
    {
        /**
 * This Step executes CommonMethods class methods and steps to achieve addition action of the calculator app.
 *
 * @return String of the addition result for validation.
 */
        //@Step("Addition between two numbers example")
        public static String performAddition()
        {
            CommonMethods.click(ManagePages.desktopCalculatorPage.getNumber(ElementsRepoConstants.first_number));
            CommonMethods.click(ManagePages.desktopCalculatorPage.getMathSign(ElementsRepoConstants.math_sign_plus));
            CommonMethods.click(ManagePages.desktopCalculatorPage.getNumber(ElementsRepoConstants.second_number));
            CommonMethods.click(ManagePages.desktopCalculatorPage.getNumber(ElementsRepoConstants.math_sign_equals));
            return ManagePages.desktopCalculatorPage.getResult();
        }
    }
}
