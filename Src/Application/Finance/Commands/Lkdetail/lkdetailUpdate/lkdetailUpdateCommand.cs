using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkdetailUpdate.lkdetailUpdateCommand
{ 
	 
	/// @author  Henok Solomon  lkdetail_Update stored procedure.
	 
	#region lkdetail_Update  
     
  /// lkdetail_Update stored procedure.
     
        public class lkdetailUpdateCommand : IRequest<IList<lkdetail_lkdetail_Code>>
    {

		public System.Guid lkdetail_Code { get; set; }
		public System.Guid lkmaster_Master_Code { get; set; }
		public string english_Description { get; set; }
		public string amharic_Description { get; set; }
		public string tigrigna_Description { get; set; }
		public string oromiffa_Description { get; set; }
	}
		
        #endregion
		
		 
	}
 
 
