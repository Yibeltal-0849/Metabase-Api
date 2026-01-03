

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cTurmsAndCreditvendor.cTurmsAndCreditvendorUpdate.cTurmsAndCreditvendorUpdateCommand
{

    /// @author  Shimels Alem  c_TurmsAndCredit_vendorUpdate stored procedure.


    public class cTurmsAndCreditvendorUpdateHandler : IRequestHandler<cTurmsAndCreditvendorUpdateCommand, IList<CTurmsAndCreditVendor_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTurmsAndCreditvendorUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTurmsAndCreditVendor_Id>> Handle( cTurmsAndCreditvendorUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CTurmsAndCreditVendor_Id> result = await _procedureAdabter
                .Execute<CTurmsAndCreditVendor_Id>("[FINA].c_TurmsAndCredit_vendorUpdate", request);
           

            return result;
        }
    }
}
 