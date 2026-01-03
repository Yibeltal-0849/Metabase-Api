
using System;

namespace XOKA.Domain.Entities.Document
{
    public class SendTO
	{
		public System.Guid Email_ID { get; set; }
		public System.Guid? Letter_ID { get; set; }
		public System.Guid? Org_ID { get; set; }
		public System.Guid? Department_ID { get; set; }
		public System.Guid? Stracture_Role_ID { get; set; }
		public bool? Cc { get; set; }

	}
}
