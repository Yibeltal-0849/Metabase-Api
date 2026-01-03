using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.Procdepartments.GetProcdepartmentsLoadAll
{
    class GetProcdepartmentsLoadAllQueryHandler : IRequestHandler<GetProcdepartmentsLoadAllQuery, GetProcdepartmentsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetProcdepartmentsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcdepartmentsLoadAllListVm> Handle(GetProcdepartmentsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_departments> Procdepartmentss = await _procedureAdabter
               .Execute<Proc_departments>("[FINA].[proc_departmentsLoadAll]");
            GetProcdepartmentsLoadAllListVm vm = new GetProcdepartmentsLoadAllListVm
            {
                Procdepartmentss = _mapper.Map<IList<Proc_departments>, IList<GetProcdepartmentsLoadAllVm>>(Procdepartmentss)
            };

            return vm;
        }
    }
}
