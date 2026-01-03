using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Inventory.Quiries.procItemReturnVocher.GetprocItemReturnVocherLoadAll;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Quiries.procItemReturnVocher.GetprocItemReturnVocherByPrimaryKey
{
    public class GetprocItemReturnVocherQueryHandler : IRequestHandler<GetprocItemReturnVocherByPrimaryKey, GetprocItemReturnVocherLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocItemReturnVocherQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocItemReturnVocherLoadAllListVm> Handle(GetprocItemReturnVocherByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ItemReturnVocher> procItemReturnVochers = await _procedureAdabter
               .Execute<ItemReturnVocher>("[Inventory].[proc_Item_Return_VocherLoadByPrimaryKey]", request);
            GetprocItemReturnVocherLoadAllListVm vm = new GetprocItemReturnVocherLoadAllListVm
            {
                procItemReturnVochers = _mapper.Map<IList<ItemReturnVocher>, IList<GetprocItemReturnVocherLoadAllVm>>(procItemReturnVochers)
            };

            return vm;
        }
    }
}
