

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.J_Payroll_Journal.J_Payroll_JournalUpdate.J_Payroll_JournalUpdateCommand
{

    /// @author  Shimels Alem  c_CA_Beginning_BalanceUpdate stored procedure.


    public class J_Payroll_JournalUpdateHandler : IRequestHandler<J_Payroll_JournalUpdateCommand, IList<J_Payroll_Journal_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public J_Payroll_JournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<J_Payroll_Journal_Trans_ID>> Handle( J_Payroll_JournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<J_Payroll_Journal_Trans_ID> result = await _procedureAdabter
                .Execute<J_Payroll_Journal_Trans_ID>("[FINA].J_Payroll_JournalUpdate", request);
           

            return result;
        }
    }
}
 