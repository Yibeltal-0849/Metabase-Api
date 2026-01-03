using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkmasterInsert.lkmasterInsertCommand
{ 
	 
	/// @author  Henok Solomon  lkmaster_Insert stored procedure.
	 
	 
      public class lkmasterInsertHandler : IRequestHandler<lkmasterInsertCommand, IList<lkmaster_lkmaster_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public lkmasterInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<lkmaster_lkmaster_Code>> Handle( lkmasterInsertCommand request, CancellationToken cancellationToken)
        {

            IList<lkmaster_lkmaster_Code> result = await _procedureAdabter
                .Execute<lkmaster_lkmaster_Code>("[FINA].lkmaster_Insert", request);
           

            return result;
        }
    }
}
 
