

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.CBankDeposit.CBankDepositUpdate.CBankDepositUpdateCommand
{

    /// @author  Shimels Alem  C_Bank_DepositUpdate stored procedure.


    public class CBankDepositUpdateHandler : IRequestHandler<CBankDepositUpdateCommand, IList<CBankDeposit_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CBankDepositUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CBankDeposit_Id>> Handle( CBankDepositUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CBankDeposit_Id> result = await _procedureAdabter
                .Execute<CBankDeposit_Id>("[FINA].C_Bank_DepositUpdate", request);
           

            return result;
        }
    }
}
 