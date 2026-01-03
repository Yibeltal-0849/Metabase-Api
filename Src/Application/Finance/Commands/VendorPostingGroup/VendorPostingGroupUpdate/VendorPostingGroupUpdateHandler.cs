

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.VendorPostingGroup.VendorPostingGroupUpdate.VendorPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  Vendor_Posting_GroupUpdate stored procedure.


    public class VendorPostingGroupUpdateHandler : IRequestHandler<VendorPostingGroupUpdateCommand, IList<VendorPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VendorPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VendorPostingGroup_Code>> Handle( VendorPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<VendorPostingGroup_Code> result = await _procedureAdabter
                .Execute<VendorPostingGroup_Code>("[FINA].Vendor_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 