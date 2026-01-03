using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procItemReturnDetail.GetprocItemReturnDetailLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemReturnDetail.GetprocItemReturnDetailByPrimaryKey
{
    public class GetprocItemReturnDetailQueryHandler : IRequestHandler<GetprocItemReturnDetailByPrimaryKey, GetprocItemReturnDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocItemReturnDetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemReturnDetailLoadAllListVm> Handle(GetprocItemReturnDetailByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ItemReturnDetail> procItemReturnDetails = await _procedureAdabter
               .Execute<ItemReturnDetail>("[Inventory].[proc_Item_Return_DetailLoadByPrimaryKey]", request);
            GetprocItemReturnDetailLoadAllListVm vm = new GetprocItemReturnDetailLoadAllListVm
            {
                procItemReturnDetails = _mapper.Map<IList<ItemReturnDetail>, IList<GetprocItemReturnDetailLoadAllVm>>(procItemReturnDetails)
            };

            return vm;
        }
    }
}
