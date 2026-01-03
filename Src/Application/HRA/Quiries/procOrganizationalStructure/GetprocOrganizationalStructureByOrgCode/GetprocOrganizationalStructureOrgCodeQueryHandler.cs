using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;
namespace Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureByOrgCode
{
    public class GetprocOrganizationalStructureOrgCodeQueryHandler : IRequestHandler<GetprocOrganizationalStructureByOrgCode, GetprocOrganizationalStructureLoadByOgrCodeAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocOrganizationalStructureOrgCodeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOrganizationalStructureLoadByOgrCodeAllListVm> Handle(GetprocOrganizationalStructureByOrgCode request, CancellationToken cancellationToken)
        {

            IList<OrganizationalStructureOrgCode> procOrganizationalStructuresOrgCode = await _procedureAdabter
               .Execute<OrganizationalStructureOrgCode>("[HRA].[proc_Organizational_StructureByOrgCode]", request);
            GetprocOrganizationalStructureLoadByOgrCodeAllListVm vm = new GetprocOrganizationalStructureLoadByOgrCodeAllListVm
            {
                procOrganizationalStructuresOrgCode = _mapper.Map<IList<OrganizationalStructureOrgCode>, IList<GetprocOrganizationalStructureLoadByOrgCodeAllVm>>(procOrganizationalStructuresOrgCode)
            };

            return vm;
        }
    }
}
