using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemActivity.GetprocItemActivityLoadAll
{
    class GetprocItemActivityLoadAllQueryHandler : IRequestHandler<GetprocItemActivityLoadAllQuery, GetprocItemActivityLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocItemActivityLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemActivityLoadAllListVm> Handle(GetprocItemActivityLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ItemActivity> procItemActivitys = await _procedureAdabter
               .Execute<ItemActivity>("[Inventory].[proc_Item_ActivityLoadAll]");
            GetprocItemActivityLoadAllListVm vm = new GetprocItemActivityLoadAllListVm
            {
                procItemActivitys = _mapper.Map<IList<ItemActivity>, IList<GetprocItemActivityLoadAllVm>>(procItemActivitys)
            };

            return vm;
        }
    }
}
