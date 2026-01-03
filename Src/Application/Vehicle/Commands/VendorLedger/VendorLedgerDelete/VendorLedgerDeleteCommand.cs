using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VendorLedger.VendorLedgerDelete.VendorLedgerDeleteCommand
{

    ///   @author  Shimels Alem Vendor_LedgerDelete stored procedure.

    public class VendorLedgerDeleteCommand : IRequest<IList<VendorLedger_Entry_No>>
    {
        public Int64 Entry_No { get; set; }

    }
		
		 
	}
 
 
