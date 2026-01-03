


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.procFixedAsset.procFixedAssetInsert.procFixedAssetInsertCommand
{

	/// public string author  Shimels Alem  proc_Fixed_AssetInsert stored procedure.


	public class procFixedAssetInsertCommand : IRequest<IList<FixedAsset_FIXED_Asset_No>>
    {
		public string FIXED_Asset_No { get; set; }
		public string Application_NO { get; set; }
		public System.Guid? FixedAsset_Trans_ID { get; set; }
		public string Name { get; set; }
		public string Fixed_Asset_Posting_Group { get; set; }
		public System.Guid? Asset_Status_Type { get; set; }
		public System.Guid? FA_Class_Code { get; set; }
		public System.Guid? FA_Class_Sub_Code { get; set; }
		public System.Guid? FA_Location_Code { get; set; }
		public string Factory_Number { get; set; }
		public System.Double? Value { get; set; }
		public System.DateTime? Purchased_Date { get; set; }
		public System.DateTime? Received_Date { get; set; }
		public System.DateTime? Commission_Date { get; set; }
		public System.DateTime? Depreciation_Start_Date { get; set; }
		public string Record_No { get; set; }
		public System.Int32? Quantity { get; set; }
		public string Unit { get; set; }
		public string Remark { get; set; }
		public System.Guid? document_detail_id { get; set; }
		public string Json_Meta_Data { get; set; }
		public string Json_Data { get; set; }
		public string Parent { get; set; }
		public string Log { get; set; }
	}
		
		
		 
}
 
 