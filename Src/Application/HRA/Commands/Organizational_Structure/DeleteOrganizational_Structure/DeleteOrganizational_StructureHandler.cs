using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.Organizational_Structure.DeleteOrganizational_Structure
{
    public class DeleteOrganizational_StructureHandler : IRequestHandler<DeleteOrganizational_StructureCommand, IList<OrganizationalStructure_Structure_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteOrganizational_StructureHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<OrganizationalStructure_Structure_ID>> Handle(DeleteOrganizational_StructureCommand request, CancellationToken cancellationToken)
        {
            Guid Structure_ID = request.Structure_ID;
            IList<OrganizationalStructure_Structure_ID> result = await _procedureAdabter
                .Execute<OrganizationalStructure_Structure_ID>("[HRA].[Organizational_StructureDelete]",
                (nameof(Structure_ID), Structure_ID));

            return result;
        }
    }
}
