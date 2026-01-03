using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.Procdepartments.GetProcdepartmentsLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.Procdepartments.GetProcdepartmentsByPrimaryKey
{
    public class GetProcdepartmentsQueryHandler : IRequestHandler<GetProcdepartmentsByPrimaryKey, GetProcdepartmentsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetProcdepartmentsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcdepartmentsLoadAllListVm> Handle(GetProcdepartmentsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Proc_departments> Procdepartmentss = await _procedureAdabter
               .Execute<Proc_departments>("[FINA].[proc_departmentsLoadByPrimaryKey]", request);
            GetProcdepartmentsLoadAllListVm vm = new GetProcdepartmentsLoadAllListVm
            {
                Procdepartmentss = _mapper.Map<IList<Proc_departments>, IList<GetProcdepartmentsLoadAllVm>>(Procdepartmentss)
            };

            return vm;
        }
    }
}
