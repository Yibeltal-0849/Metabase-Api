



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procPJobLineType.procPJobLineTypeInsert.procPJobLineTypeInsertCommand
{

    /// @author  Shimels Alem  proc_P_Job_Line_TypeInsert stored procedure.


    public class procPJobLineTypeInsertHandler : IRequestHandler<procPJobLineTypeInsertCommand, IList<PJobLineType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPJobLineTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PJobLineType_Code>> Handle( procPJobLineTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PJobLineType_Code> result = await _procedureAdabter
                .Execute<PJobLineType_Code>("[FINA].proc_P_Job_Line_TypeInsert", request);
           

            return result;
        }
    }
}
 