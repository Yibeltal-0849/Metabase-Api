

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblInstitution.proctblInstitutionUpdate.proctblInstitutionUpdateCommand
{ 
	 
	/// @author  Shimels Alem  XXXXX stored procedure.
	 
	 
      public class proctblInstitutionUpdateHandler : IRequestHandler<proctblInstitutionUpdateCommand, IList<tblInstitution_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblInstitutionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblInstitution_id>> Handle( proctblInstitutionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblInstitution_id> result = await _procedureAdabter
                .Execute<tblInstitution_id>("[ProprtyData].proc_tblInstitutionUpdate", request);
           

            return result;
        }
    }
}
 