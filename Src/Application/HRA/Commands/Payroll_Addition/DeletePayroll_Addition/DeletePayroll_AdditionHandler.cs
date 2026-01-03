using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Payroll_Addition.DeletePayroll_Addition
{
    public class DeletePayroll_AdditionHandler : IRequestHandler<DeletePayroll_AdditionCommand, IList<PayrollAddition_Addion_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeletePayroll_AdditionHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PayrollAddition_Addion_ID>> Handle(DeletePayroll_AdditionCommand request, CancellationToken cancellationToken)
        {
            string Addion_ID = request.Addion_ID;
            IList<PayrollAddition_Addion_ID> result = await _procedureAdabter
                .Execute<PayrollAddition_Addion_ID>("[HRA].[Payroll_AdditionDelete]",
                (nameof(Addion_ID), Addion_ID));

            return result;
        }
    }
}
