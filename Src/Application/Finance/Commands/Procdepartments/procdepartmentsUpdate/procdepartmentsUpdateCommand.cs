using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procdepartmentsUpdate.procdepartmentsUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_departmentsUpdate stored procedure.
	 
	#region proc_departmentsUpdate  
     
  /// proc_departmentsUpdate stored procedure.
     
        public class procdepartmentsUpdateCommand : IRequest<IList<Proc_departments_department_Code>>
    {

		public System.Guid? department_Code { get; set; }
		public string department_Name { get; set; }
		public string Code { get; set; }
		public System.Guid? departments_Department_Code { get; set; }
		public System.Guid organizations_Organization_Code { get; set; }
        public bool is_active { get; set; }


    }

    #endregion


}
 
 
