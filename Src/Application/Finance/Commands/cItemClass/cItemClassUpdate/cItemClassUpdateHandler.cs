

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cItemClass.cItemClassUpdate.cItemClassUpdateCommand
{

    /// @author  Shimels Alem  c_ItemClassUpdate stored procedure.


    public class cItemClassUpdateHandler : IRequestHandler<cItemClassUpdateCommand, IList<CItemClass_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cItemClassUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CItemClass_Name>> Handle( cItemClassUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CItemClass_Name> result = await _procedureAdabter
                .Execute<CItemClass_Name>("[FINA].c_ItemClassUpdate", request);
           

            return result;
        }
    }
}
 