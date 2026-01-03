using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procVendorLedger.procVendorLedgerDelete.procVendorLedgerDeleteCommand
{

    /// @author  Shimels Alem  proc_Vendor_LedgerDelete stored procedure.


    public class procVendorLedgerDeleteHandler : IRequestHandler<procVendorLedgerDeleteCommand, IList<VendorLedger_Entry_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVendorLedgerDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VendorLedger_Entry_No>> Handle( procVendorLedgerDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<VendorLedger_Entry_No> result = await _procedureAdabter
                .Execute<VendorLedger_Entry_No>("[FINA].proc_Vendor_LedgerDelete", request);
           

            return result;
        }
    }
}
  