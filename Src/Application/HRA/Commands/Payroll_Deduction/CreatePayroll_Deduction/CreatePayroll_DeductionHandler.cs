using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payroll_Deduction.CreatePayroll_Deduction
{
    public class CreatePayroll_DeductionHandler : IRequestHandler<CreatePayroll_DeductionCommand, IList<PayrollDeduction_Diduction_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreatePayroll_DeductionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollDeduction_Diduction_ID>> Handle(CreatePayroll_DeductionCommand request, CancellationToken cancellationToken)
        {
            if (request.Pos_ID == null || request.Pos_ID == Guid.Empty)
                throw new ArgumentException("Pos_ID is required and must be a valid GUID");

            var newId = Guid.NewGuid();

            var parameters = new
            {
                Diduction_ID = newId,
                Pos_ID = request.Pos_ID,
                Diducation_Type = request.Diducation_Type,
                Unit = request.Unit,
                QTY = request.QTY,
                Unit_Price = request.Unit_Price,
                is_Active = request.is_Active,
                Remark = request.Remark,
                Is_Personal = request.Is_Personal
            };

            var result = await _procedureAdabter.Execute<PayrollDeduction_Diduction_ID>(
                "[HRA].[Payroll_DeductionInsert]", parameters);

            return result;
        }

    }
}
