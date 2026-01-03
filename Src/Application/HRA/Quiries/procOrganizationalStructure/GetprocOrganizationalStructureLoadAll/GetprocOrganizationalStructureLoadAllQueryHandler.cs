using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procOrganizationalStructure.GetprocOrganizationalStructureLoadAll
{
    class GetprocOrganizationalStructureLoadAllQueryHandler : IRequestHandler<GetprocOrganizationalStructureLoadAllQuery, GetprocOrganizationalStructureLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocOrganizationalStructureLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocOrganizationalStructureLoadAllListVm> Handle(GetprocOrganizationalStructureLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<OrganizationalStructure> procOrganizationalStructures = await _procedureAdabter
               .Execute<OrganizationalStructure>("[HRA].[proc_Organizational_StructureLoadAll]");
            GetprocOrganizationalStructureLoadAllListVm vm = new GetprocOrganizationalStructureLoadAllListVm
            {
                procOrganizationalStructures = _mapper.Map<IList<OrganizationalStructure>, IList<GetprocOrganizationalStructureLoadAllVm>>(procOrganizationalStructures)
            };

            return vm;
        }
    }
}
