using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Organizational_Structure.CreateOrganizational_Structure
{
    public class CreateOrganizational_StructureHandler : IRequestHandler<CreateOrganizational_StructureCommand, IList<OrganizationalStructure_Structure_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CreateOrganizational_StructureHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OrganizationalStructure_Structure_ID>> Handle(CreateOrganizational_StructureCommand request, CancellationToken cancellationToken)
        {

            IList<OrganizationalStructure_Structure_ID> result = await _procedureAdabter
                    .Execute<OrganizationalStructure_Structure_ID>("[HRA].[Organizational_StructureInsert]", request);

            return result;
        }

    }
}
