using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmployeePay_Slip.UpdateCEmployeePay_Slip
{
    public class UpdateCEmployeePay_SlipHandler : IRequestHandler<UpdateCEmployeePay_SlipCommand, IList<PaySlip_Pay_Slip_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCEmployeePay_SlipHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PaySlip_Pay_Slip_ID>> Handle(UpdateCEmployeePay_SlipCommand request, CancellationToken cancellationToken)
        {

            IList<PaySlip_Pay_Slip_ID> result = await _procedureAdabter
                .Execute<PaySlip_Pay_Slip_ID>("[HRA].[proc_c_EmployeePaySlipUpdate]", request);

            return result;
        }
    }
}
