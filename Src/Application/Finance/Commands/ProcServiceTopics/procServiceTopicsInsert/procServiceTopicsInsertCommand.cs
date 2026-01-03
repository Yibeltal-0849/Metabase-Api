using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procServiceTopicsInsert.procServiceTopicsInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Service_TopicsInsert stored procedure.
	 
	#region proc_Service_TopicsInsert  
     
  /// proc_Service_TopicsInsert stored procedure.
     
        public class procServiceTopicsInsertCommand : IRequest<IList<Service_Topics>>
    {
    
 
		public System.Guid topic_Code  { get; set; }
		public System.Guid service_Code  { get; set; } 
    }
		
        #endregion
		
		 
	}
 
 
