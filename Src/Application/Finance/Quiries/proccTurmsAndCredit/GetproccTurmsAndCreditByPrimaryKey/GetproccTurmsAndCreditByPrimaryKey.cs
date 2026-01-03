using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccTurmsAndCredit.GetproccTurmsAndCreditLoadAll;

namespace Application.Finance.Quiries.proccTurmsAndCredit.GetproccTurmsAndCreditByPrimaryKey
{
    /// @author  Shimels Alem proc_c_TurmsAndCreditLoadByPrimaryKey stored procedure.

    public class GetproccTurmsAndCreditByPrimaryKey : IRequest<GetproccTurmsAndCreditLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
