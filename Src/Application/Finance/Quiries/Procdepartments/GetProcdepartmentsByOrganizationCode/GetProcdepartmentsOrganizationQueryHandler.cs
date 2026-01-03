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

namespace Application.Finance.Quiries.Procdepartments.GetProcdepartmentsByOrganizationCode
{
    public class GetProcdepartmentsOrganizationQueryHandler : IRequestHandler<GetProcdepartmentsByOrganizationCode, GetProcdepartmentsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetProcdepartmentsOrganizationQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcdepartmentsLoadAllListVm> Handle(GetProcdepartmentsByOrganizationCode request, CancellationToken cancellationToken)
        {

            IList<Proc_departments> Procdepartmentss = await _procedureAdabter
               .Execute<Proc_departments>("[FINA].[proc_departmentsLoadByorganizationsorganizationcode]", request);
            GetProcdepartmentsLoadAllListVm vm = new GetProcdepartmentsLoadAllListVm
            {
                Procdepartmentss = _mapper.Map<IList<Proc_departments>, IList<GetProcdepartmentsLoadAllVm>>(Procdepartmentss)
            };

            return vm;
        }
    }
}
