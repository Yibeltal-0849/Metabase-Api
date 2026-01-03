using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmployee.DeleteCEmployee
{
    public class DeleteCEmployeeHandler : IRequestHandler<DeleteCEmployeeCommand, IList<CEmployee_Employee_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCEmployeeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmployee_Employee_Id>> Handle(DeleteCEmployeeCommand request, CancellationToken cancellationToken)
        {
            string Employee_ID = request.Employee_Id;
            IList<CEmployee_Employee_Id> result = await _procedureAdabter
                .Execute<CEmployee_Employee_Id>("[HRA].[C_EmployeeDelete]",
                (nameof(Employee_ID), Employee_ID));

            return result;
        }
    }
}
