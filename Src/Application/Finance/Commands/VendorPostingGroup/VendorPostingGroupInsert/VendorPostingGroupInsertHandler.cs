



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.VendorPostingGroup.VendorPostingGroupInsert.VendorPostingGroupInsertCommand
{

    /// @author  Shimels Alem  Vendor_Posting_GroupInsert stored procedure.


    public class VendorPostingGroupInsertHandler : IRequestHandler<VendorPostingGroupInsertCommand, IList<VendorPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VendorPostingGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VendorPostingGroup_Code>> Handle( VendorPostingGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<VendorPostingGroup_Code> result = await _procedureAdabter
                .Execute<VendorPostingGroup_Code>("[FINA].Vendor_Posting_GroupInsert", request);
           

            return result;
        }
    }
}
 