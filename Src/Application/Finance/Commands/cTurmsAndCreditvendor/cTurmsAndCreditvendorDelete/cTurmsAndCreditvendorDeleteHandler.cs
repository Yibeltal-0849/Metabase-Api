using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cTurmsAndCreditvendor.cTurmsAndCreditvendorDelete.cTurmsAndCreditvendorDeleteCommand
{

    /// @author  Shimels Alem  c_TurmsAndCredit_vendorDelete stored procedure.


    public class cTurmsAndCreditvendorDeleteHandler : IRequestHandler<cTurmsAndCreditvendorDeleteCommand, IList<CTurmsAndCreditVendor_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTurmsAndCreditvendorDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTurmsAndCreditVendor_Id>> Handle( cTurmsAndCreditvendorDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CTurmsAndCreditVendor_Id> result = await _procedureAdabter
                .Execute<CTurmsAndCreditVendor_Id>("[FINA].c_TurmsAndCredit_vendorDelete", request);
           

            return result;
        }
    }
}
  