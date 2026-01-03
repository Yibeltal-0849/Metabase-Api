

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procVendorLedger.procVendorLedgerUpdate.procVendorLedgerUpdateCommand
{

    /// @author  Shimels Alem  proc_Vendor_LedgerUpdate stored procedure.


    public class procVendorLedgerUpdateHandler : IRequestHandler<procVendorLedgerUpdateCommand, IList<VendorLedger_Entry_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVendorLedgerUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VendorLedger_Entry_No>> Handle( procVendorLedgerUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<VendorLedger_Entry_No> result = await _procedureAdabter
                .Execute<VendorLedger_Entry_No>("[FINA].proc_Vendor_LedgerUpdate", request);
           

            return result;
        }
    }
}
 