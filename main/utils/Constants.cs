using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectTemplate.main.utils
{
    /*
        This class hold constant parameters for configuration and file paths.
    */
    class Constants
    {

        // General
        public const String LOG_ERROR_MESSAGE = "Error accrued: ";

        // Platform options: Web, Desktop, Mobile.
        public  const String PLATFORM = "web";

        // Driver Implicit wait time(seconds).
        public  const int IMPLICIT_WAIT_TIME = 10;

        // Driver Explicit wait time(seconds).
        public const int EXPLICIT_WAIT_TIME = 20;

        // Driver Page load time out(seconds).
        public const int PAGE_LOAD_TIME_OUT = 15;


        //Web

        // Browser type options: Chrome, Safari, Edge, ie(Internet Explorer), FireFox, Opera.
        public const String BROWSER_TYPE = "Chrome";


        // Desktop

        // Windows Calculator.
        public const String EXPECTED_CALC_RESULT = "Display is 11";

        // Application path.
        public const String APP_PATH = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";

        // IPPort
        public const String IP_PORT = "http://127.0.0.1:4723";


        // Mobile

        // Application UD_ID.
        public const String UD_ID = "";

        // Application package.
        public const String APP_PACKAGE = "";

        // Application activity.
        public const String APP_ACTIVITY = ".MainActivity";

        // Driver URL.
        public const String DRIVER_URL = "";

        // Report directory name.
        public const String REPORT_DIRECTORY = "";

        // Report format.
        public const String REPORT_FORMAT = "xml";

        // Test name.
        public const String TEST_NAME = "";


        // Test Project Demo Login credentials and form data.

        //login
        public const String USER_NAME = "Test";
        public const String PASSWORD = "12345";

        // Form data.
        public const String COUNTRY_TO_SELECT = "Israel";
        public const String ADDRESS = "Israel israel 1";
        public const String EMAIL = "Israel@Israel.com";
        public const String PHONE_NUMBER = "+972509991111";
        public const String EXPECTED_TEXT = "Saved";

    }
}
