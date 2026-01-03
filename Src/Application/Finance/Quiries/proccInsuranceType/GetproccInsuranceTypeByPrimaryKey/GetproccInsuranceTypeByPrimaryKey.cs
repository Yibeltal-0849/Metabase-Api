using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccInsuranceType.GetproccInsuranceTypeLoadAll;

namespace Application.Finance.Quiries.proccInsuranceType.GetproccInsuranceTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_c_InsuranceTypeLoadByPrimaryKey stored procedure.

    public class GetproccInsuranceTypeByPrimaryKey : IRequest<GetproccInsuranceTypeLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
