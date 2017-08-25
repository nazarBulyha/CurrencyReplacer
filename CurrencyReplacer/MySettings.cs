using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace CurrencyReplacer
{
    [Serializable()]
    public class MySettings
    {
        public string SearchWord = "EUR";
        public string FileExtension = "*.txt";
        public string SourcePath = @"C:\Work\";
        public string DestinationPath = @"C:\Work1";

        //TODO: implement Serialize
        public void Serialize(MySettings mySettings)
        {
            XmlDocument myXml = new XmlDocument();
            XPathNavigator xNav = myXml.CreateNavigator();
            XmlSerializer x = new XmlSerializer(typeof(MySettings));
            using (var xs = xNav.AppendChild())
            {
                x.Serialize(xs, mySettings);
            }
        }

        public MySettings Deserialize()
        {
            FileStream readStream = new FileStream("settings.xml", FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MySettings));
            MySettings mySettings = (MySettings)xmlSerializer.Deserialize(readStream);

            return mySettings;
        }
    }
}