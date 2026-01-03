

using MediatR;
using System.Collections.Generic;
using Application.Finance.Quiries.procADOrg.GetprocADOrgLoadAll;

namespace Application.Finance.Quiries.procADOrg.GetADOrgLoadByPrimaryKey
{

    #region procADOrgLoadByPrimaryKey  

    public class GetprocADOrgLoadByPrimaryKey : IRequest<GetprocADOrgLoadAllListVM>
    {

        public string Code { get; set; }

    }

    #endregion

 }

