
using System;

namespace XOKA.Domain.Entities.Document
{
    public class DocumentArchive
    {

		public string Document_Number { get; set; }
		public string Title_Deed_No { get; set; }
		public DateTime? Regstration_Date { get; set; }
		public string Application_No { get; set; }
		public string Room { get; set; }
		public string Site { get; set; }
		public string Block_Floor { get; set; }
		public string Shelf_NO { get; set; }
		public string Shelf_Raw { get; set; }
		public string Shelf_Column { get; set; }
		public Guid? Created_By  { get; set; }
		public Guid? Updated_By  { get; set; }
		public Guid? Deleted_By  { get; set; }
		public bool? Is_Deleted { get; set; }
		public DateTime? Created_Date { get; set; }
		public DateTime? Updated_Date { get; set; }
		public DateTime? Deleted_Date { get; set; }


    }
}
