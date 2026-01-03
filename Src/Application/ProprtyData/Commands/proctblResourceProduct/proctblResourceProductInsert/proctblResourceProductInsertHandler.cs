



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResourceProduct.proctblResourceProductInsert.proctblResourceProductInsertCommand
{

    /// @author  Shimels Alem  proc_tblResource_ProductInsert stored procedure.


    public class proctblResourceProductInsertHandler : IRequestHandler<proctblResourceProductInsertCommand, IList<tblResourceProduct_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceProductInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceProduct_id>> Handle( proctblResourceProductInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceProduct_id> result = await _procedureAdabter
                .Execute<tblResourceProduct_id>("[ProprtyData].proc_tblResource_ProductInsert", request);
           

            return result;
        }
    }
}
 