using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemActivity.GetprocItemActivityByPrimaryKey
{
    public class GetprocItemActivityQueryHandler : IRequestHandler<GetprocItemActivityByPrimaryKey, GetprocItemActivityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocItemActivityQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemActivityLoadAllListVm> Handle(GetprocItemActivityByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ItemActivity> procItemActivitys = await _procedureAdabter
               .Execute<ItemActivity>("[Inventory].[proc_Item_ActivityLoadByPrimaryKey]", request);
            GetprocItemActivityLoadAllListVm vm = new GetprocItemActivityLoadAllListVm
            {
                procItemActivitys = _mapper.Map<IList<ItemActivity>, IList<GetprocItemActivityLoadAllVm>>(procItemActivitys)
            };

            return vm;
        }
    }
}
