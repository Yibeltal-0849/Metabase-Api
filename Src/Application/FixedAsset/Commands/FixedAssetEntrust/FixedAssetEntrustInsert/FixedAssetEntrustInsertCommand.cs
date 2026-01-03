


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.FixedAssetEntrust.FixedAssetEntrustInsert.FixedAssetEntrustInsertCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_EntrustInsert stored procedure.


    public class FixedAssetEntrustInsertCommand : IRequest<IList<FixedAssetEntrust_Entrust_ID>>
    {
        public System.Guid Entrust_ID { get; set; }
        public string FIXED_Asset_No { get; set; }
        public System.Guid? Entrust_Trans_ID { get; set; }
        public string Address { get; set; }
        public bool? Is_Active { get; set; }
        public System.Guid? Pervious_Enterus { get; set; }
        public string Record_No { get; set; }
        public string Remark { get; set; }
        public string Log { get; set; }
    }
		
		
		 
	}
 
 