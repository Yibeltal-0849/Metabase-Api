using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblDocumentDetail.proctblDocumentDetailUpdate.proctblDocumentDetailUpdateCommand
{

	/// @author  Shimels Alem  proc_tblDocument_DetailUpdate stored procedure.


	public class proctblDocumentDetailUpdateCommand : IRequest<IList<tblDocumentDetail_id>>
   {
		public long id { get; set; }
		public long Document_id { get; set; }
		public string Author { get; set; }
		public string Title { get; set; }
		public string Publisher { get; set; }
		public System.DateTime? Publicationed_Date { get; set; }
		public string Volume { get; set; }
		public int? Number { get; set; }
		public int? Pages { get; set; }
		public string TypeCategory { get; set; }
		public string ISBN { get; set; }
		public string Abstract { get; set; }
		public string URL { get; set; }
	}
		
		
		 
}

