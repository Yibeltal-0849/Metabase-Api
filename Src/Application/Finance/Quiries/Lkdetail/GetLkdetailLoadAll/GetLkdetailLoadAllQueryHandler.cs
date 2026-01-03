using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.Lkdetail.GetLkdetailLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.Lkdetail.GetLkdetailLoadAll
{
    class GetLkdetailLoadAllQueryHandler : IRequestHandler<GetLkdetailLoadAllQuery, GetLkdetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetLkdetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetLkdetailLoadAllListVm> Handle(GetLkdetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<lkdetail> Lkdetails = await _procedureAdabter
               .Execute<lkdetail>("[FINA].[lkdetail_GetRecords]");
            GetLkdetailLoadAllListVm vm = new GetLkdetailLoadAllListVm
            {
                Lkdetails = _mapper.Map<IList<lkdetail>, IList<GetLkdetailLoadAllVm>>(Lkdetails)
            };

            return vm;
        }
    }
}
