using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procFixedAssetMent.procFixedAssetMentUpdate.procFixedAssetMentUpdateCommand
{

	/// @author  Shimels Alem  proc_Fixed_Asset_MentUpdate stored procedure.


	public class procFixedAssetMentUpdateCommand : IRequest<IList<FixedAssetMent_Maintainance_ID>>
   {
		public string Maintainance_ID { get; set; }
		public string Remark { get; set; }
		public Guid? FixedAsset_Maintan_Trans_ID { get; set; }
		public DateTime? Mainanace_Request_Date { get; set; }
		public string FIXED_Asset_No { get; set; }
		public string Unit { get; set; }
		public Double? Quantity { get; set; }
		public string Vocher_NO { get; set; }
	}
		
		
		 
}

