using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkmasterUpdate.lkmasterUpdateCommand
{ 
	 
	/// @author  Henok Solomon  lkmaster_Update stored procedure.
	 
	 
      public class lkmasterUpdateHandler : IRequestHandler<lkmasterUpdateCommand, IList<lkmaster_lkmaster_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public lkmasterUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<lkmaster_lkmaster_Code>> Handle( lkmasterUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<lkmaster_lkmaster_Code> result = await _procedureAdabter
                .Execute<lkmaster_lkmaster_Code>("[FINA].lkmaster_Update", request);
           

            return result;
        }
    }
}
 
