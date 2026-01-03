using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procStoreItemActivityTypeDelete.procStoreItemActivityTypeDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Store_Item_Activity_TypeDelete stored procedure.
	 
	 
      public class procStoreItemActivityTypeDeleteHandler : IRequestHandler<procStoreItemActivityTypeDeleteCommand, IList<Store_Item_Activity_Type_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procStoreItemActivityTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Store_Item_Activity_Type_Code>> Handle( procStoreItemActivityTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Store_Item_Activity_Type_Code> result = await _procedureAdabter
                .Execute<Store_Item_Activity_Type_Code>("[FINA].proc_Store_Item_Activity_TypeDelete", request);
           

            return result;
        }
    }
}
 
