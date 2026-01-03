using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Currency_ID.DeleteCCurrencyID
{
    public class DeleteCCurrencyIDHandler : IRequestHandler<DeleteCCurrencyIDCommand, IList<Proc_C_Currency_ID_CurrencyID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCCurrencyIDHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Currency_ID_CurrencyID>> Handle(DeleteCCurrencyIDCommand request, CancellationToken cancellationToken)
        {
            string CurrencyID = request.CurrencyID;
            IList<Proc_C_Currency_ID_CurrencyID> result = await _procedureAdabter
                .Execute<Proc_C_Currency_ID_CurrencyID>("[BSC].[proc_C_Currency_IDDelete]", (nameof(CurrencyID), CurrencyID));

            return result;
        }
    }
}
