using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XOKA.Domain.Entities.Finance
{
   public  class C2BPaymentValidationRequestmapsecured
    {

        [XmlElement("UserId")]
        public string? UserId { get; set; }
       
        [XmlElement("Password")]
        public string?Password { get; set; }
        [XmlElement("PasswordSalt")]
        public string?PasswordSalt { get; set; }
        [XmlElement("UserName")]
        public string?UserName { get; set; }

    }
}
