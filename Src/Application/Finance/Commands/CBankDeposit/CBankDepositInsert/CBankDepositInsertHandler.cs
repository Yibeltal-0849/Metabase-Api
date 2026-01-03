



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CBankDeposit.CBankDepositInsert.CBankDepositInsertCommand
{

    /// @author  Shimels Alem  C_Bank_DepositInsert stored procedure.


    public class CBankDepositInsertHandler : IRequestHandler<CBankDepositInsertCommand, IList<CBankDeposit_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CBankDepositInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CBankDeposit_Id>> Handle( CBankDepositInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CBankDeposit_Id> result = await _procedureAdabter
                .Execute<CBankDeposit_Id>("[FINA].C_Bank_DepositInsert", request);
           

            return result;
        }
    }
}
 