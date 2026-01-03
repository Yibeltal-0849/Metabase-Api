using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Commands.LetterTransaction.LetterTransactionUpdate.LetterTransactionUpdateCommand
{

	/// @author  Shimels Alem  proc_Letter_TransactionUpdate stored procedure.


	public class LetterTransactionUpdateCommand : IRequest<IList<Letter_Transaction_Letter_ID>>
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

