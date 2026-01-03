using System;
using System.Collections.Generic;
using System.Text;

namespace Application.dbo.Quiries.procPropertyRegistration.GetprocPropertyRegistrationLoadAll
{
    /// @author  Shimels Alem  proc_Property_RegistrationLoadAll stored procedure.

    public class GetprocPropertyRegistrationLoadAllListVm
    {
        public IList<GetprocPropertyRegistrationLoadAllVm> procPropertyRegistrations { get; set; }
    }
}
