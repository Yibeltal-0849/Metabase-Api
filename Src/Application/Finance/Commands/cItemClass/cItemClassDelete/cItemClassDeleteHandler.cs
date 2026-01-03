using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cItemClass.cItemClassDelete.cItemClassDeleteCommand
{

    /// @author  Shimels Alem  c_ItemClassDelete stored procedure.


    public class cItemClassDeleteHandler : IRequestHandler<cItemClassDeleteCommand, IList<CItemClass_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cItemClassDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemClass_Name>> Handle( cItemClassDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CItemClass_Name> result = await _procedureAdabter
                .Execute<CItemClass_Name>("[FINA].c_ItemClassDelete", request);
           

            return result;
        }
    }
}
  