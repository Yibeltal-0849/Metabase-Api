using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Domain.Entities.Finance
{
   public class Cash_Flow_Setting
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string GL_Account { get; set; }
        public string Formula { get; set; }
        public bool? Is_Active { get; set; }

    }
}
