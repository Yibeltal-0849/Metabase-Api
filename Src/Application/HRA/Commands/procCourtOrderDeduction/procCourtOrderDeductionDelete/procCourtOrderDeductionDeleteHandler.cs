using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.HRA;
using System.Collections.Generic;

namespace Application.HRA.Commands.procCourtOrderDeduction.procCourtOrderDeductionDelete.procCourtOrderDeductionDeleteCommand
{

    /// @author  Shimels Alem  proc_Court_Order_DeductionDelete stored procedure.


    public class procCourtOrderDeductionDeleteHandler : IRequestHandler<procCourtOrderDeductionDeleteCommand, IList<CourtOrderDeduction_CourtOrderID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCourtOrderDeductionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CourtOrderDeduction_CourtOrderID>> Handle( procCourtOrderDeductionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CourtOrderDeduction_CourtOrderID> result = await _procedureAdabter
                .Execute<CourtOrderDeduction_CourtOrderID>("[HRA].proc_Court_Order_DeductionDelete", request);
           

            return result;
        }
    }
}
  