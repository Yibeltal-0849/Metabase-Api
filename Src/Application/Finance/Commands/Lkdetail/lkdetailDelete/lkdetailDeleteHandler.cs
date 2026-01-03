using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkdetailDelete.lkdetailDeleteCommand
{ 
	 
	/// @author  Henok Solomon  lkdetail_Delete stored procedure.
	 
	 
      public class lkdetailDeleteHandler : IRequestHandler<lkdetailDeleteCommand, IList<lkdetail_lkdetail_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public lkdetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<lkdetail_lkdetail_Code>> Handle( lkdetailDeleteCommand request, CancellationToken cancellationToken)
        {
            System.Guid lkdetail_Code = request.lkdetail_Code;
            IList<lkdetail_lkdetail_Code> result = await _procedureAdabter
                .Execute<lkdetail_lkdetail_Code>("[FINA].lkdetail_Delete" , (nameof(lkdetail_Code), lkdetail_Code));
           

            return result;
        }
    }
}
 
