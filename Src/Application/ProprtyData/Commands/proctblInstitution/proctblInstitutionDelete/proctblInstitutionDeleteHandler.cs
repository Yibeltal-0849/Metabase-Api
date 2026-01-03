using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblInstitution.proctblInstitutionDelete.proctblInstitutionDeleteCommand
{

    /// @author  Shimels Alem  proc_tblInstitutionDelete stored procedure.


    public class proctblInstitutionDeleteHandler : IRequestHandler<proctblInstitutionDeleteCommand, IList<tblInstitution_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblInstitutionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblInstitution_id>> Handle( proctblInstitutionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblInstitution_id> result = await _procedureAdabter
                .Execute<tblInstitution_id>("[ProprtyData].proc_tblInstitutionDelete", request);
           

            return result;
        }
    }
}
  