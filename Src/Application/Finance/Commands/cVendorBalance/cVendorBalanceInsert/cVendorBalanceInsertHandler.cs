



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cVendorBalance.cVendorBalanceInsert.cVendorBalanceInsertCommand
{

    /// @author  Shimels Alem  c_Vendor_BalanceInsert stored procedure.


    public class cVendorBalanceInsertHandler : IRequestHandler<cVendorBalanceInsertCommand, IList<CVendor_Vendor_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cVendorBalanceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CVendor_Vendor_ID>> Handle( cVendorBalanceInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CVendor_Vendor_ID> result = await _procedureAdabter
                .Execute<CVendor_Vendor_ID>("[FINA].c_Vendor_BalanceInsert", request);
           

            return result;
        }
    }
}
 