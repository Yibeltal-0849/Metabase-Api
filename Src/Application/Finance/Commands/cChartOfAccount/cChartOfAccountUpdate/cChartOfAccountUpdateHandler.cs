

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cChartOfAccount.cChartOfAccountUpdate.cChartOfAccountUpdateCommand
{

    /// @author  Shimels Alem  c_Chart_Of_AccountUpdate stored procedure.


    public class cChartOfAccountUpdateHandler : IRequestHandler<cChartOfAccountUpdateCommand, IList<CChartOfAccount_Account_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cChartOfAccountUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CChartOfAccount_Account_ID>> Handle( cChartOfAccountUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CChartOfAccount_Account_ID> result = await _procedureAdabter
                .Execute<CChartOfAccount_Account_ID>("[FINA].c_Chart_Of_AccountUpdate", request);
           

            return result;
        }
    }
}
 