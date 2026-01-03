using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkdetailUpdate.lkdetailUpdateCommand
{ 
	 
	/// @author  Henok Solomon  lkdetail_Update stored procedure.
	 
	 
      public class lkdetailUpdateHandler : IRequestHandler<lkdetailUpdateCommand, IList<lkdetail_lkdetail_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public lkdetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<lkdetail_lkdetail_Code>> Handle( lkdetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<lkdetail_lkdetail_Code> result = await _procedureAdabter
                .Execute<lkdetail_lkdetail_Code>("[FINA].lkdetail_Update", request);
           

            return result;
        }
    }
}
 
