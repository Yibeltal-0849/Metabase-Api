

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.proccItemClass.proccItemClassUpdate.proccItemClassUpdateCommand
{

    /// @author  Shimels Alem  proc_c_ItemClassUpdate stored procedure.


    public class proccItemClassUpdateHandler : IRequestHandler<proccItemClassUpdateCommand, IList<CItemClass_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccItemClassUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemClass_Name>> Handle( proccItemClassUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CItemClass_Name> result = await _procedureAdabter
                .Execute<CItemClass_Name>("[Inventory].proc_c_ItemClassUpdate", request);
           

            return result;
        }
    }
}
 