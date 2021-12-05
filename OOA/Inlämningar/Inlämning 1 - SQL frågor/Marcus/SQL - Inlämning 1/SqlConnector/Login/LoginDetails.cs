using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SQL___Inlämning_1
{
    public class LoginDetails
    {
        [XmlElement(ElementName = "name")]
        public string? Name { get; set; }
        [XmlElement(ElementName = "password")]
        public string? Password { get; set; }
        [XmlElement(ElementName = "server")]
        public string? Server { get; set; }
    }
}
