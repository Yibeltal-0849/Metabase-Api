



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procVendorLedger.procVendorLedgerInsert.procVendorLedgerInsertCommand
{

    /// @author  Shimels Alem  proc_Vendor_LedgerInsert stored procedure.


    public class procVendorLedgerInsertHandler : IRequestHandler<procVendorLedgerInsertCommand, IList<VendorLedger_Entry_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procVendorLedgerInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VendorLedger_Entry_No>> Handle( procVendorLedgerInsertCommand request, CancellationToken cancellationToken)
        {

            IList<VendorLedger_Entry_No> result = await _procedureAdabter
                .Execute<VendorLedger_Entry_No>("[FINA].proc_Vendor_LedgerInsert", request);
           

            return result;
        }
    }
}
 