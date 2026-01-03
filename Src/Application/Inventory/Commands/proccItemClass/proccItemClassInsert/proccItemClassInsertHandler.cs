



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.proccItemClass.proccItemClassInsert.proccItemClassInsertCommand
{

    /// @author  Shimels Alem  proc_c_ItemClassInsert stored procedure.


    public class proccItemClassInsertHandler : IRequestHandler<proccItemClassInsertCommand, IList<CItemClass_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccItemClassInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemClass_Name>> Handle( proccItemClassInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CItemClass_Name> result = await _procedureAdabter
                .Execute<CItemClass_Name>("[Inventory].proc_c_ItemClassInsert", request);
           

            return result;
        }
    }
}
 