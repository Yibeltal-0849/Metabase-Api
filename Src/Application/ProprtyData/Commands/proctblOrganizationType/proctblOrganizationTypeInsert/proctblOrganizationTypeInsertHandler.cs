



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblOrganizationType.proctblOrganizationTypeInsert.proctblOrganizationTypeInsertCommand
{

    /// @author  Shimels Alem  proc_tblOrganization_TypeInsert stored procedure.


    public class proctblOrganizationTypeInsertHandler : IRequestHandler<proctblOrganizationTypeInsertCommand, IList<tblOrganizationType_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblOrganizationTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblOrganizationType_id>> Handle( proctblOrganizationTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblOrganizationType_id> result = await _procedureAdabter
                .Execute<tblOrganizationType_id>("[ProprtyData].proc_tblOrganization_TypeInsert", request);
           

            return result;
        }
    }
}
 