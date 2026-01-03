


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.LetterTransaction.LetterTransactionInsert.LetterTransactionInsertCommand
{

	/// @author  Shimels Alem  proc_Letter_TransactionInsert stored procedure.


	public class LetterTransactionInsertCommand : IRequest<IList<Letter_Transaction_Letter_ID>>
	{
		public System.Guid Letter_ID { get; set; }
		public System.Guid? Application_Code { get; set; }
		public string Application_NO { get; set; }
		public string Ref_No { get; set; }
		public string From { get; set; }
		public string To { get; set; }
		public bool? Is_IN { get; set; }
		public bool? IS_Out { get; set; }
		public string Subject { get; set; }
		public int? Number_Of_Page { get; set; }
		public int? Number_Of_Attachment { get; set; }
		public System.DateTime? Letter_written_Date { get; set; }
		public string Document_Details { get; set; }
		public System.Guid? Recived_By { get; set; }
		public string RecivedBy_Name { get; set; }
	}
		
		
		 
}
 
 