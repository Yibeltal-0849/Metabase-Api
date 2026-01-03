using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkdetailInsert.lkdetailInsertCommand
{ 
	 
	/// @author  Henok Solomon  lkdetail_Insert stored procedure.
	 
	#region lkdetail_Insert  
     
  /// lkdetail_Insert stored procedure.
     
        public class lkdetailInsertCommand : IRequest<IList<lkdetail_lkdetail_Code>>
    {
    
		public System.Guid lkdetail_Code  { get; set; }
		public System.Guid lkmaster_Master_Code  { get; set; }
		public string  english_Description  { get; set; }
		public string  amharic_Description  { get; set; }
		public string  tigrigna_Description  { get; set; }
		public string  oromiffa_Description  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
