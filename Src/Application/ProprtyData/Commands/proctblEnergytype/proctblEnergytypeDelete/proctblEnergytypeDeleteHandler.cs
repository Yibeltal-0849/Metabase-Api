using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblEnergytype.proctblEnergytypeDelete.proctblEnergytypeDeleteCommand
{ 
	 
	/// @author  Shimels Alem  XXXXXXXX stored procedure.
	 
	 
      public class proctblEnergytypeDeleteHandler : IRequestHandler<proctblEnergytypeDeleteCommand, IList<tblEnergytype_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblEnergytypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblEnergytype_id>> Handle( proctblEnergytypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblEnergytype_id> result = await _procedureAdabter
                .Execute<tblEnergytype_id>("[ProprtyData].proc_tblEnergy_typeDelete", request);
           

            return result;
        }
    }
}
  