using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procdepartmentsDelete.procdepartmentsDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_departmentsDelete stored procedure.
	 
	#region proc_departmentsDelete  
     
  /// proc_departmentsDelete stored procedure.
     
        public class procdepartmentsDeleteCommand : IRequest<IList<Proc_departments_department_Code>>
    {
    
		public System.Guid department_Code { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
