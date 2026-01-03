using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cItemGeneral.cItemGeneralDelete.cItemGeneralDeleteCommand
{

    /// @author  Shimels Alem  c_ItemGeneralDelete stored procedure.


    public class cItemGeneralDeleteHandler : IRequestHandler<cItemGeneralDeleteCommand, IList<CItemGeneral_Item_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cItemGeneralDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemGeneral_Item_id>> Handle( cItemGeneralDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CItemGeneral_Item_id> result = await _procedureAdabter
                .Execute<CItemGeneral_Item_id>("[FINA].c_ItemGeneralDelete", request);
           

            return result;
        }
    }
}
  