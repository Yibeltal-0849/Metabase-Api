using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblGroup.proctblGroupDelete.proctblGroupDeleteCommand
{ 
	 
	/// @author  Shimels Alem  XXXXXXXX stored procedure.
	 
	 
      public class proctblGroupDeleteHandler : IRequestHandler<proctblGroupDeleteCommand, IList<tblGroup_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblGroup_id>> Handle( proctblGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblGroup_id> result = await _procedureAdabter
                .Execute<tblGroup_id>("[ProprtyData].proc_tblGroupDelete", request);
           

            return result;
        }
    }
}
  