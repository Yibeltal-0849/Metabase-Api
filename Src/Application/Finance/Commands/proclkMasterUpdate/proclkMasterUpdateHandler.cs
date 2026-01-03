using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proclkMasterUpdate.proclkMasterUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_lkMasterUpdate stored procedure.
	 
	 
      public class proclkMasterUpdateHandler : IRequestHandler<proclkMasterUpdateCommand, IList<lkmaster_lkmaster_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proclkMasterUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<lkmaster_lkmaster_Code>> Handle( proclkMasterUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<lkmaster_lkmaster_Code> result = await _procedureAdabter
                .Execute<lkmaster_lkmaster_Code>("[FINA].proc_lkMasterUpdate", request);
           

            return result;
        }
    }
}
 
