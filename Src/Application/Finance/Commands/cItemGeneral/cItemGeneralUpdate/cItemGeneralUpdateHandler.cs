

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cItemGeneral.cItemGeneralUpdate.cItemGeneralUpdateCommand
{

    /// @author  Shimels Alem  c_ItemGeneralUpdate stored procedure.


    public class cItemGeneralUpdateHandler : IRequestHandler<cItemGeneralUpdateCommand, IList<CItemGeneral_Item_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cItemGeneralUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemGeneral_Item_id>> Handle( cItemGeneralUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CItemGeneral_Item_id> result = await _procedureAdabter
                .Execute<CItemGeneral_Item_id>("[FINA].c_ItemGeneralUpdate", request);
           

            return result;
        }
    }
}
 