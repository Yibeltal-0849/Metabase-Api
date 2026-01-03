



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CVendor.CVendorInsert.CVendorInsertCommand
{

    /// @author  Shimels Alem  C_VendorInsert stored procedure.


    public class CVendorInsertHandler : IRequestHandler<CVendorInsertCommand, IList<CVendor_Vendor_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CVendorInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CVendor_Vendor_ID>> Handle( CVendorInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CVendor_Vendor_ID> result = await _procedureAdabter
                .Execute<CVendor_Vendor_ID>("[FINA].C_VendorInsert", request);
           

            return result;
        }
    }
}
 