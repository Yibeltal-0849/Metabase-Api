using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Pay_Slip.DeletePay_Slip
{
    public class DeletePay_SlipHandler : IRequestHandler<DeletePay_SlipCommand, IList<PaySlip_Pay_Slip_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeletePay_SlipHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaySlip_Pay_Slip_ID>> Handle(DeletePay_SlipCommand request, CancellationToken cancellationToken)
        {
            Guid Pay_Slip_ID = request.Pay_Slip_ID;
            IList<PaySlip_Pay_Slip_ID> result = await _procedureAdabter
                .Execute<PaySlip_Pay_Slip_ID>("[HRA].[Pay_SlipDelete]",
                (nameof(Pay_Slip_ID), Pay_Slip_ID));

            return result;
        }
    }
}
