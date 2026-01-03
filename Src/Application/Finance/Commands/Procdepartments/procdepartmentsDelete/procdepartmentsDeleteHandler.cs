using Application.Finance.Commands.procdepartmentsInsert.procdepartmentsInsertCommand;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procdepartmentsDelete.procdepartmentsDeleteCommand
{

    /// @author  Henok Solomon  proc_departmentsDelete stored procedure.


    public class procdepartmentsInsertHandler : IRequestHandler<procdepartmentsInsertCommand, IList<Proc_departments_department_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public procdepartmentsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_departments_department_Code>> Handle(procdepartmentsInsertCommand request, CancellationToken cancellationToken)
        {
            // Ensure a new Guid is generated if department_Code is not provided
            if (request.department_Code == Guid.Empty)
            {
                request.department_Code = Guid.NewGuid();
            }

            IList<Proc_departments_department_Code> result = await _procedureAdabter
                .Execute<Proc_departments_department_Code>("[FINA].proc_departmentsInsert", request);

            return result;
        }
    }

}

