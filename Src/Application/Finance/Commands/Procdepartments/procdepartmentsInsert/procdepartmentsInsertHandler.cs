using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procdepartmentsInsert.procdepartmentsInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_departmentsInsert stored procedure.
	 
	 
      public class procdepartmentsInsertHandler : IRequestHandler<procdepartmentsInsertCommand, IList<Proc_departments_department_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procdepartmentsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_departments_department_Code>> Handle( procdepartmentsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Proc_departments_department_Code> result = await _procedureAdabter
                .Execute<Proc_departments_department_Code>("[FINA].proc_departmentsInsert", request);
           

            return result;
        }
    }
}
 
