using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proclkDetailDelete.proclkDetailDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_lkDetailDelete stored procedure.
	 
	 
      public class proclkDetailDeleteHandler : IRequestHandler<proclkDetailDeleteCommand, IList<lkdetail_lkdetail_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proclkDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<lkdetail_lkdetail_Code>> Handle( proclkDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<lkdetail_lkdetail_Code> result = await _procedureAdabter
                .Execute<lkdetail_lkdetail_Code>("[FINA].[proc_lkDetailDelete]", request);
           

            return result;
        }
    }
}
 
