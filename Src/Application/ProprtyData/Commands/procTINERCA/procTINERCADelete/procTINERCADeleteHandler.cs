using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procTINERCA.procTINERCADelete.procTINERCADeleteCommand
{

    /// @author  Shimels Alem  proc_TIN_ERCADelete stored procedure.


    public class procTINERCADeleteHandler : IRequestHandler<procTINERCADeleteCommand, IList<TINERCA_TIN>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTINERCADeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TINERCA_TIN>> Handle( procTINERCADeleteCommand request, CancellationToken cancellationToken)
        {

            IList<TINERCA_TIN> result = await _procedureAdabter
                .Execute<TINERCA_TIN>("[JOB_Creation].[Tax].proc_TIN_ERCADelete", request);
           

            return result;
        }
    }
}
  