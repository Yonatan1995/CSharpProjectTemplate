using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace CSharpProjectTemplate.main.utils
{
    /**
    * This class is a helper class for reading property from .properties file.
    */
    class PropertyReader
    {
        /**
         * This method reads propertyName from "elementsRepo.properties" file.
         * returns the value of the given key.
         *
         * @param propertyName the property to read from.
         * @return the property string value.
         */
        public static String readElementsRepoItem(String propertyName)
        {
            return readItemFromFile("C:\\Users\\Yonat\\Desktop\\CSharpProjectTemplate\\CSharpProjectTemplate\\main\\resources\\elementsRepo.xml", propertyName);
        }

        /**
         * This method loads the properties file using given path and return the value of the given key.
         *
         * @param path         the properties file path.
         * @param propertyName the property to read from.
         * @return the property string value.
         */
        public static String readItemFromFile(String path, String propertyName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            //XmlNodeList nodes = doc.SelectNodes("props/key");
            try
            {
                XmlNode node = doc.DocumentElement.SelectSingleNode("/keys/" + propertyName + "");
                return node.InnerText;
                //foreach (XmlNode node in nodes)
                //{
                //    XmlAttributeCollection nodeAtt = node.Attributes;
                //    if (nodeAtt["name"].Value.ToString() == propertyName)
                //    {
                //        XmlDocument childNode = new XmlDocument();
                //        childNode.LoadXml(node.OuterXml);
                //        return childNode.SelectSingleNode("key/value").InnerText;
                //    }
                //    else
                //    {
                //        return "did not match any documents";
                //    }
            //}
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return "No key value pair found";
        }
    }
}
