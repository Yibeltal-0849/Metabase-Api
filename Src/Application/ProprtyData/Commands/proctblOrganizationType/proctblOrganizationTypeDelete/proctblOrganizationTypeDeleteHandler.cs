using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblOrganizationType.proctblOrganizationTypeDelete.proctblOrganizationTypeDeleteCommand
{

    /// @author  Shimels Alem  proc_tblOrganization_TypeDelete stored procedure.


    public class proctblOrganizationTypeDeleteHandler : IRequestHandler<proctblOrganizationTypeDeleteCommand, IList<tblOrganizationType_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblOrganizationTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblOrganizationType_id>> Handle( proctblOrganizationTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblOrganizationType_id> result = await _procedureAdabter
                .Execute<tblOrganizationType_id>("[ProprtyData].proc_tblOrganization_TypeDelete", request);
           

            return result;
        }
    }
}
  