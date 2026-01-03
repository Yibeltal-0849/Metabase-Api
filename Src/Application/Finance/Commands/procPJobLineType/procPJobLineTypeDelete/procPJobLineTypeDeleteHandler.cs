using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPJobLineType.procPJobLineTypeDelete.procPJobLineTypeDeleteCommand
{

    /// @author  Shimels Alem  proc_P_Job_Line_TypeDelete stored procedure.


    public class procPJobLineTypeDeleteHandler : IRequestHandler<procPJobLineTypeDeleteCommand, IList<PJobLineType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPJobLineTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PJobLineType_Code>> Handle( procPJobLineTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PJobLineType_Code> result = await _procedureAdabter
                .Execute<PJobLineType_Code>("[FINA].proc_P_Job_Line_TypeDelete", request);
           

            return result;
        }
    }
}
  