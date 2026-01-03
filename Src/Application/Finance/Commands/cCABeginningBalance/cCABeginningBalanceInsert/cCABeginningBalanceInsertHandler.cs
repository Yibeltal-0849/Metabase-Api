



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cCABeginningBalance.cCABeginningBalanceInsert.cCABeginningBalanceInsertCommand
{

    /// @author  Shimels Alem  c_CA_Beginning_BalanceInsert stored procedure.


    public class cCABeginningBalanceInsertHandler : IRequestHandler<cCABeginningBalanceInsertCommand, IList<CCaBeginningBalance_Period>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cCABeginningBalanceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCaBeginningBalance_Period>> Handle( cCABeginningBalanceInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CCaBeginningBalance_Period> result = await _procedureAdabter
                .Execute<CCaBeginningBalance_Period>("[FINA].c_CA_Beginning_BalanceInsert", request);
           

            return result;
        }
    }
}
 