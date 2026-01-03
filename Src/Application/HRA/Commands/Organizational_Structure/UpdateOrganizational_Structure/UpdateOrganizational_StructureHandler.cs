using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Organizational_Structure.UpdateOrganizational_Structure
{
    public class UpdateOrganizational_StructureHandler : IRequestHandler<UpdateOrganizational_StructureCommand, IList<OrganizationalStructure_Structure_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateOrganizational_StructureHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OrganizationalStructure_Structure_ID>> Handle(UpdateOrganizational_StructureCommand request, CancellationToken cancellationToken)
        {

            IList<OrganizationalStructure_Structure_ID> result = await _procedureAdabter
                .Execute<OrganizationalStructure_Structure_ID>("[HRA].[Organizational_StructureUpdate]", request);

            return result;
        }
    }
}
