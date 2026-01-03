using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.procTAXProdPostingGroup.procTAXProdPostingGroupDelete.procTAXProdPostingGroupDeleteCommand
{

    /// @author  Shimels Alem  proc_TAX_Prod_Posting_GroupDelete stored procedure.


    public class procTAXProdPostingGroupDeleteHandler : IRequestHandler<procTAXProdPostingGroupDeleteCommand, IList<TAX_Prod_Posting_Group_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTAXProdPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TAX_Prod_Posting_Group_Code>> Handle( procTAXProdPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<TAX_Prod_Posting_Group_Code> result = await _procedureAdabter
                .Execute<TAX_Prod_Posting_Group_Code>("[Inventory].proc_TAX_Prod_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
  