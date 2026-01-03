

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cCABeginningBalance.cCABeginningBalanceUpdate.cCABeginningBalanceUpdateCommand
{

    /// @author  Shimels Alem  c_CA_Beginning_BalanceUpdate stored procedure.


    public class cCABeginningBalanceUpdateHandler : IRequestHandler<cCABeginningBalanceUpdateCommand, IList<CCaBeginningBalance_Period>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cCABeginningBalanceUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCaBeginningBalance_Period>> Handle( cCABeginningBalanceUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CCaBeginningBalance_Period> result = await _procedureAdabter
                .Execute<CCaBeginningBalance_Period>("[FINA].c_CA_Beginning_BalanceUpdate", request);
           

            return result;
        }
    }
}
 