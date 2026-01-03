using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.proccItemClass.proccItemClassDelete.proccItemClassDeleteCommand
{

    /// @author  Shimels Alem  proc_c_ItemClassDelete stored procedure.


    public class proccItemClassDeleteHandler : IRequestHandler<proccItemClassDeleteCommand, IList<CItemClass_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccItemClassDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemClass_Name>> Handle( proccItemClassDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CItemClass_Name> result = await _procedureAdabter
                .Execute<CItemClass_Name>("[Inventory].proc_c_ItemClassDelete", request);
           

            return result;
        }
    }
}
  