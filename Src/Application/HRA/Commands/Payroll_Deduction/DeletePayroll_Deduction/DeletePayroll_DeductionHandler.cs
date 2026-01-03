using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payroll_Deduction.DeletePayroll_Deduction
{
    public class DeletePayroll_DeductionHandler : IRequestHandler<DeletePayroll_DeductionCommand, IList<PayrollDeduction_Diduction_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeletePayroll_DeductionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollDeduction_Diduction_ID>> Handle(DeletePayroll_DeductionCommand request, CancellationToken cancellationToken)
        {
            Guid Diduction_ID = request.Diduction_ID;
            IList<PayrollDeduction_Diduction_ID> result = await _procedureAdabter
                .Execute<PayrollDeduction_Diduction_ID>("[HRA].[Payroll_DeductionDelete]",
                (nameof(Diduction_ID), Diduction_ID));

            return result;
        }
    }
}
