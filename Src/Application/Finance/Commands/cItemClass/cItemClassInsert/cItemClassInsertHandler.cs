



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cItemClass.cItemClassInsert.cItemClassInsertCommand
{

    /// @author  Shimels Alem  c_ItemClassInsert stored procedure.


    public class cItemClassInsertHandler : IRequestHandler<cItemClassInsertCommand, IList<CItemClass_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cItemClassInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemClass_Name>> Handle( cItemClassInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CItemClass_Name> result = await _procedureAdabter
                .Execute<CItemClass_Name>("[FINA].c_ItemClassInsert", request);
           

            return result;
        }
    }
}
 