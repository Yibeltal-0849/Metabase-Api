using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.dbo.Quiries.procProperty_Document.GetprocProperty_DocumentLoadAll;

namespace Application.dbo.Quiries.procProperty_Document.GetprocProperty_DocumentLoadByPrimaryKey_FIXEDAssetNO
{
    /// @author  Shimels Alem proc_Property_RegistrationLoadByPrimaryKey_FIXED_Asset_NO stored procedure.

    public class GetprocProperty_DocumentLoadByPrimaryKey_FIXEDAssetNO : IRequest<GetprocProperty_DocumentLoadAllListVm2>
    {
        public System.Guid ID { get; set; }
    }
}
