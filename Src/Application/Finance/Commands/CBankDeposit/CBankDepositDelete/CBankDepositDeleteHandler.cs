using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CBankDeposit.CBankDepositDelete.CBankDepositDeleteCommand
{

    /// @author  Shimels Alem  C_Bank_DepositDelete stored procedure.


    public class CBankDepositDeleteHandler : IRequestHandler<CBankDepositDeleteCommand, IList<CBankDeposit_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CBankDepositDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CBankDeposit_Id>> Handle( CBankDepositDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CBankDeposit_Id> result = await _procedureAdabter
                .Execute<CBankDeposit_Id>("[FINA].C_Bank_DepositDelete", request);
           

            return result;
        }
    }
}
  