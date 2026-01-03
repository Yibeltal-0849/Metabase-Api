using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procStoreItemActivityType.GetprocStoreItemActivityTypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procStoreItemActivityType.GetprocStoreItemActivityTypeByPrimaryKey
{
    public class GetprocStoreItemActivityTypeQueryHandler : IRequestHandler<GetprocStoreItemActivityTypeByPrimaryKey, GetprocStoreItemActivityTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocStoreItemActivityTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStoreItemActivityTypeLoadAllListVm> Handle(GetprocStoreItemActivityTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_procStoreItemActivityType> procStoreItemActivityTypes = await _procedureAdabter
               .Execute<_procStoreItemActivityType>("[FINA].[proc_Store_Item_Activity_TypeLoadByPrimaryKey]", request);
            GetprocStoreItemActivityTypeLoadAllListVm vm = new GetprocStoreItemActivityTypeLoadAllListVm
            {
                procStoreItemActivityTypes = _mapper.Map<IList<_procStoreItemActivityType>, IList<GetprocStoreItemActivityTypeLoadAllVm>>(procStoreItemActivityTypes)
            };

            return vm;
        }
    }
}
