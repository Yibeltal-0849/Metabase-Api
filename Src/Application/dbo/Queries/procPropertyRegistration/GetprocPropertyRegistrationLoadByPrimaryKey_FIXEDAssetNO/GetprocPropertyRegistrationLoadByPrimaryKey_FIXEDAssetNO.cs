using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.procPropertyRegistration.GetprocPropertyRegistrationLoadAll;

namespace Application.dbo.Quiries.procPropertyRegistration.GetprocPropertyRegistrationLoadByPrimaryKey_FIXEDAssetNO
{
    /// @author  Shimels Alem proc_Property_RegistrationLoadByPrimaryKey_FIXED_Asset_NO stored procedure.

    public class GetprocPropertyRegistrationLoadByPrimaryKey_FIXEDAssetNO : IRequest<GetprocPropertyRegistrationLoadAllListVm2>
    {
        public string FIXED_Asset_NO { get; set; }
    }
}
