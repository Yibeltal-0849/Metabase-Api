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

namespace Application.Finance.Quiries.Lkdetail.GetLkdetailByPrimaryKey
{
    public class GetLkdetailQueryHandler : IRequestHandler<GetLkdetailByPrimaryKey, GetLkdetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetLkdetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetLkdetailLoadAllListVm> Handle(GetLkdetailByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<lkdetail> Lkdetails = await _procedureAdabter
               .Execute<lkdetail>("[FINA].[lkdetail_GetRecord]", request);
            GetLkdetailLoadAllListVm vm = new GetLkdetailLoadAllListVm
            {
                Lkdetails = _mapper.Map<IList<lkdetail>, IList<GetLkdetailLoadAllVm>>(Lkdetails)
            };

            return vm;
        }
    }
}
