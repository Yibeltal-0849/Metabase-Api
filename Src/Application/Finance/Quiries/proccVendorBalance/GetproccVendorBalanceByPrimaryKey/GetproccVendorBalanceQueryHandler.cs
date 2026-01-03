using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccVendorBalance.GetproccVendorBalanceLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccVendorBalance.GetproccVendorBalanceByPrimaryKey
{
    public class GetproccVendorBalanceQueryHandler : IRequestHandler<GetproccVendorBalanceByPrimaryKey, GetproccVendorBalanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccVendorBalanceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccVendorBalanceLoadAllListVm> Handle(GetproccVendorBalanceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CVendorBalance> proccVendorBalances = await _procedureAdabter
               .Execute<CVendorBalance>("[FINA].[proc_c_Vendor_BalanceLoadByPrimaryKey]", request);
            GetproccVendorBalanceLoadAllListVm vm = new GetproccVendorBalanceLoadAllListVm
            {
                proccVendorBalances = _mapper.Map<IList<CVendorBalance>, IList<GetproccVendorBalanceLoadAllVm>>(proccVendorBalances)
            };

            return vm;
        }
    }
}
