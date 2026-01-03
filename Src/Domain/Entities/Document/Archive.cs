
using System;

namespace XOKA.Domain.Entities.Document
{
    public class Archive
	{
		public string FolderNO { get; set; }
		public string Name { get; set; }
		public string Archive_Type { get; set; }
		public string Shelf_Raw { get; set; }
		public string Shelf_Column { get; set; }
		public System.Guid Letter_ID { get; set; }

	}
}
