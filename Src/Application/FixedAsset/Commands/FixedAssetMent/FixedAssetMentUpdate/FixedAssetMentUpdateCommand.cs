using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetMent.FixedAssetMentUpdate.FixedAssetMentUpdateCommand
{

    /// @author  Shimels Alem  Fixed_Asset_MentUpdate stored procedure.


    public class FixedAssetMentUpdateCommand : IRequest<IList<FixedAssetMent_Maintainance_ID>>
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

