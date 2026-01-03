

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cVendorBalance.cVendorBalanceUpdate.cVendorBalanceUpdateCommand
{

    /// @author  Shimels Alem  c_Vendor_BalanceUpdate stored procedure.


    public class cVendorBalanceUpdateHandler : IRequestHandler<cVendorBalanceUpdateCommand, IList<CVendor_Vendor_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cVendorBalanceUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CVendor_Vendor_ID>> Handle( cVendorBalanceUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CVendor_Vendor_ID> result = await _procedureAdabter
                .Execute<CVendor_Vendor_ID>("[FINA].c_Vendor_BalanceUpdate", request);
           

            return result;
        }
    }
}
 