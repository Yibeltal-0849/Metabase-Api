using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkdetailInsert.lkdetailInsertCommand
{ 
	 
	/// @author  Henok Solomon  lkdetail_Insert stored procedure.
	 
	 
      public class lkdetailInsertHandler : IRequestHandler<lkdetailInsertCommand, IList<lkdetail_lkdetail_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public lkdetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<lkdetail_lkdetail_Code>> Handle( lkdetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<lkdetail_lkdetail_Code> result = await _procedureAdabter
                .Execute<lkdetail_lkdetail_Code>("[FINA].lkdetail_Insert", request);
           

            return result;
        }
    }
}
 
