using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payroll_Deduction.UpdatePayroll_Deduction
{
    public class UpdatePayroll_DeductionHandler : IRequestHandler<UpdatePayroll_DeductionCommand, IList<PayrollDeduction_Diduction_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdatePayroll_DeductionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollDeduction_Diduction_ID>> Handle(UpdatePayroll_DeductionCommand request, CancellationToken cancellationToken)
        {

            IList<PayrollDeduction_Diduction_ID> result = await _procedureAdabter
                .Execute<PayrollDeduction_Diduction_ID>("[HRA].[Payroll_DeductionUpdate]", request);

            return result;
        }
    }
}
