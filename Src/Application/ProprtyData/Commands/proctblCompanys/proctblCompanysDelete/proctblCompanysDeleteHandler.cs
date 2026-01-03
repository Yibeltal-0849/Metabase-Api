using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblCompanys.proctblCompanysDelete.proctblCompanysDeleteCommand
{

    /// @author  Shimels Alem  proc_tblCompanysDelete stored procedure.


    public class proctblCompanysDeleteHandler : IRequestHandler<proctblCompanysDeleteCommand, IList<tblCompanys_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblCompanysDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblCompanys_id>> Handle( proctblCompanysDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblCompanys_id> result = await _procedureAdabter
                .Execute<tblCompanys_id>("[ProprtyData].proc_tblCompanysDelete", request);
           

            return result;
        }
    }
}
  