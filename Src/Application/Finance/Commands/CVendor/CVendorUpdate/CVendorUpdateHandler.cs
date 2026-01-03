

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.CVendor.CVendorUpdate.CVendorUpdateCommand
{

    /// @author  Shimels Alem  C_VendorUpdate stored procedure.


    public class CVendorUpdateHandler : IRequestHandler<CVendorUpdateCommand, IList<CVendor_Vendor_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CVendorUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CVendor_Vendor_ID>> Handle( CVendorUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CVendor_Vendor_ID> result = await _procedureAdabter
                .Execute<CVendor_Vendor_ID>("[FINA].C_VendorUpdate", request);
           
            return result;
        }
    }
}
 