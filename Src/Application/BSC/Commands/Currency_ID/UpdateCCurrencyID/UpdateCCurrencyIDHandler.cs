using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Currency_ID.UpdateCCurrencyID
{
    public class UpdateCCurrencyIDHandler : IRequestHandler<UpdateCCurrencyIDCommand, IList<Proc_C_Currency_ID_CurrencyID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCCurrencyIDHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Currency_ID_CurrencyID>> Handle(UpdateCCurrencyIDCommand request, CancellationToken cancellationToken)
        {
            string CurrencyID = request.CurrencyID;
            string Name = request.Name;
            long? Enable = request.Enable;
            double? Current_Value_To_Birr = request.Current_Value_To_Birr;
            IList<Proc_C_Currency_ID_CurrencyID> result = await _procedureAdabter
                .Execute<Proc_C_Currency_ID_CurrencyID>("[BSC].[proc_C_Currency_IDUpdate]", (nameof(CurrencyID), CurrencyID), (nameof(Name), Name),
                (nameof(Enable), Enable), (nameof(Current_Value_To_Birr), Current_Value_To_Birr));

            return result;
        }
    }
}
