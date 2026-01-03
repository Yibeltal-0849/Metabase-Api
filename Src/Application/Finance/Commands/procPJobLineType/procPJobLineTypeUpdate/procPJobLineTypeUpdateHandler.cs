

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procPJobLineType.procPJobLineTypeUpdate.procPJobLineTypeUpdateCommand
{

    /// @author  Shimels Alem  proc_P_Job_Line_TypeUpdate stored procedure.


    public class procPJobLineTypeUpdateHandler : IRequestHandler<procPJobLineTypeUpdateCommand, IList<PJobLineType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPJobLineTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PJobLineType_Code>> Handle( procPJobLineTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PJobLineType_Code> result = await _procedureAdabter
                .Execute<PJobLineType_Code>("[FINA].proc_P_Job_Line_TypeUpdate", request);
           

            return result;
        }
    }
}
 