using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procdepartmentsInsert.procdepartmentsInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_departmentsInsert stored procedure.
	 
	#region proc_departmentsInsert  
     
  /// proc_departmentsInsert stored procedure.
     
        public class procdepartmentsInsertCommand : IRequest<IList<Proc_departments_department_Code>>
    {
    
		public System.Guid? department_Code { get; set; }
		public string Code { get; set; }
		public string  department_Name { get; set; }
        public System.Guid? departments_Department_Code { get; set; }
        public System.Guid organizations_Organization_Code { get; set; }
        public bool is_active { get; set; }


    }

    #endregion


}
 
 
