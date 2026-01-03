



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cItemGeneral.cItemGeneralInsert.cItemGeneralInsertCommand
{

    /// @author  Shimels Alem  c_ItemGeneralInsert stored procedure.


    public class cItemGeneralInsertHandler : IRequestHandler<cItemGeneralInsertCommand, IList<CItemGeneral_Item_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cItemGeneralInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemGeneral_Item_id>> Handle( cItemGeneralInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CItemGeneral_Item_id> result = await _procedureAdabter
                .Execute<CItemGeneral_Item_id>("[FINA].c_ItemGeneralInsert", request);
           

            return result;
        }
    }
}
 