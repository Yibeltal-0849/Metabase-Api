using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procStoreItemActivityType.GetprocStoreItemActivityTypeLoadAll
{
    class GetprocStoreItemActivityTypeLoadAllQueryHandler : IRequestHandler<GetprocStoreItemActivityTypeLoadAllQuery, GetprocStoreItemActivityTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocStoreItemActivityTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocStoreItemActivityTypeLoadAllListVm> Handle(GetprocStoreItemActivityTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_procStoreItemActivityType> procStoreItemActivityTypes = await _procedureAdabter
               .Execute<_procStoreItemActivityType>("[FINA].[proc_Store_Item_Activity_TypeLoadAll]");
            GetprocStoreItemActivityTypeLoadAllListVm vm = new GetprocStoreItemActivityTypeLoadAllListVm
            {
                procStoreItemActivityTypes = _mapper.Map<IList<_procStoreItemActivityType>, IList<GetprocStoreItemActivityTypeLoadAllVm>>(procStoreItemActivityTypes)
            };

            return vm;
        }
    }
}
