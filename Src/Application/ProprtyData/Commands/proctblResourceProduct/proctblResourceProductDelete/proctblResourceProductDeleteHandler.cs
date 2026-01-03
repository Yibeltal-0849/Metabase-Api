using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceProduct.proctblResourceProductDelete.proctblResourceProductDeleteCommand
{

    /// @author  Shimels Alem  proc_tblResource_ProductDelete stored procedure.


    public class proctblResourceProductDeleteHandler : IRequestHandler<proctblResourceProductDeleteCommand, IList<tblResourceProduct_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceProductDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceProduct_id>> Handle( proctblResourceProductDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceProduct_id> result = await _procedureAdabter
                .Execute<tblResourceProduct_id>("[ProprtyData].proc_tblResource_ProductDelete", request);
           

            return result;
        }
    }
}
  