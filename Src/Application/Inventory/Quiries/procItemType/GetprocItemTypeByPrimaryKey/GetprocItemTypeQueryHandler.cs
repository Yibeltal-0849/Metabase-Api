using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procItemType.GetprocItemTypeLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemType.GetprocItemTypeByPrimaryKey
{
    public class GetprocItemTypeQueryHandler : IRequestHandler<GetprocItemTypeByPrimaryKey, GetprocItemTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocItemTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemTypeLoadAllListVm> Handle(GetprocItemTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ItemType> procItemTypes = await _procedureAdabter
               .Execute<ItemType>("[Inventory].[proc_ItemTypeLoadByPrimaryKey]", request);
            GetprocItemTypeLoadAllListVm vm = new GetprocItemTypeLoadAllListVm
            {
                procItemTypes = _mapper.Map<IList<ItemType>, IList<GetprocItemTypeLoadAllVm>>(procItemTypes)
            };

            return vm;
        }
    }
}
