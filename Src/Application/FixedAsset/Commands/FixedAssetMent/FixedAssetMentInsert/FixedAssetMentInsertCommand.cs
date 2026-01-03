


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.FixedAssetMent.FixedAssetMentInsert.FixedAssetMentInsertCommand
{

    /// @author  Shimels Alem  Fixed_Asset_MentInsert stored procedure.


    public class FixedAssetMentInsertCommand : IRequest<IList<FixedAssetMent_Maintainance_ID>>
    {
		public string Maintainance_ID { get; set; }
		public System.Guid? FixedAsset_Maintan_Trans_ID { get; set; }
		public System.DateTime? Mainanace_Request_Date { get; set; }
		public string FIXED_Asset_No { get; set; }
		public string Unit { get; set; }
		public double? Quantity { get; set; }
		public string Remark { get; set; }
		public string Vocher_NO { get; set; }
	}
		
		
		 
	}
 
 