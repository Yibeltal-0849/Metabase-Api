using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VendorLedger.VendorLedgerUpdate.VendorLedgerUpdateCommand
{ 

      public class VendorLedgerUpdateHandler : IRequestHandler<VendorLedgerUpdateCommand, IList<VendorLedger_Entry_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VendorLedgerUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VendorLedger_Entry_No>> Handle( VendorLedgerUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<VendorLedger_Entry_No> result = await _procedureAdabter
                .Execute<VendorLedger_Entry_No>("[Vehicle].Vendor_LedgerUpdate", request);
           

            return result;
        }
    }
}
 
