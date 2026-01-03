



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cChartOfAccount.cChartOfAccountInsert.cChartOfAccountInsertCommand
{

    /// @author  Shimels Alem  c_Chart_Of_AccountInsert stored procedure.


    public class cChartOfAccountInsertHandler : IRequestHandler<cChartOfAccountInsertCommand, IList<CChartOfAccount_Account_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cChartOfAccountInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CChartOfAccount_Account_ID>> Handle( cChartOfAccountInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CChartOfAccount_Account_ID> result = await _procedureAdabter
                .Execute<CChartOfAccount_Account_ID>("[FINA].c_Chart_Of_AccountInsert", request);
           

            return result;
        }
    }
}
 