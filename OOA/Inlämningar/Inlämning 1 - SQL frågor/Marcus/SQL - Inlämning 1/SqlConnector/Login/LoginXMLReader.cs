using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SQL___Inlämning_1
{
    public class LoginXMLReader
    {
        public List<LoginDetails>logins { get; set; } = new();

        public List<LoginDetails> Read()
        {
            XmlSerializer xmls = new XmlSerializer(typeof(LoginDetails[]));

            string fileName="login.xml";

            if(File.Exists(fileName))
            {
                using (var sr = new StreamReader(fileName))
                {
                    try
                    {
                        foreach (var login in (LoginDetails[])xmls.Deserialize(sr))
                            logins.Add(login);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                Console.WriteLine("login.xml didn't exist. Creating it...");
                using (var sr = File.Create(fileName))
                {
                    logins.Add(new LoginDetails() { Name = "*Enter username here*", Password = "*Enter password here*", Server = "*Enter server here*" });
                    xmls.Serialize(sr, logins.ToArray());
                }
            }

            return logins;  
        }
        
        public void Write()
        {
            List<LoginDetails> logins = new();
            XmlSerializer xmls = new XmlSerializer(typeof(LoginDetails[]));

            using(StreamWriter sw = new StreamWriter("login.xml"))
            {
                xmls.Serialize(sw, logins.ToArray());
            }
        }

        public bool IsNull(LoginDetails details)
        {
            if (details is null || details.Name == null || details.Password == null || details.Server == null)
                return true;
            else
                return false;
        }
    }
}
