



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cTurmsAndCreditvendor.cTurmsAndCreditvendorInsert.cTurmsAndCreditvendorInsertCommand
{

    /// @author  Shimels Alem  c_TurmsAndCredit_vendorInsert stored procedure.


    public class cTurmsAndCreditvendorInsertHandler : IRequestHandler<cTurmsAndCreditvendorInsertCommand, IList<CTurmsAndCreditVendor_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTurmsAndCreditvendorInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTurmsAndCreditVendor_Id>> Handle( cTurmsAndCreditvendorInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CTurmsAndCreditVendor_Id> result = await _procedureAdabter
                .Execute<CTurmsAndCreditVendor_Id>("[FINA].c_TurmsAndCredit_vendorInsert", request);
           

            return result;
        }
    }
}
 