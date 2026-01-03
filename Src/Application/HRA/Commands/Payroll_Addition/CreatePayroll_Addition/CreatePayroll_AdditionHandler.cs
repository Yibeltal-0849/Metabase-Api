using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payroll_Addition.CreatePayroll_Addition
{
    public class CreatePayroll_AdditionHandler : IRequestHandler<CreatePayroll_AdditionCommand, IList<PayrollAddition_Addion_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreatePayroll_AdditionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollAddition_Addion_ID>> Handle(CreatePayroll_AdditionCommand request, CancellationToken cancellationToken)
        {

            IList<PayrollAddition_Addion_ID> result = await _procedureAdabter
                    .Execute<PayrollAddition_Addion_ID>("[HRA].[Payroll_AdditionInsert]", request);

            return result;
        }

    }
}
