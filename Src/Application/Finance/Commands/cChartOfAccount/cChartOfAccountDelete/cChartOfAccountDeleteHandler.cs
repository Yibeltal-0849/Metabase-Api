using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cChartOfAccount.cChartOfAccountDelete.cChartOfAccountDeleteCommand
{

    /// @author  Shimels Alem  c_Chart_Of_AccountDelete stored procedure.


    public class cChartOfAccountDeleteHandler : IRequestHandler<cChartOfAccountDeleteCommand, IList<CChartOfAccount_Account_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cChartOfAccountDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CChartOfAccount_Account_ID>> Handle( cChartOfAccountDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CChartOfAccount_Account_ID> result = await _procedureAdabter
                .Execute<CChartOfAccount_Account_ID>("[FINA].c_Chart_Of_AccountDelete", request);
           

            return result;
        }
    }
}
  