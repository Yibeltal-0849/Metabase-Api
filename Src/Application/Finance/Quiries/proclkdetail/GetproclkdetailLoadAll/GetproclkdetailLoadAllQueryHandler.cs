using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proclkdetail.GetproclkdetailLoadAll
{
    class GetproclkdetailLoadAllQueryHandler : IRequestHandler<GetproclkdetailLoadAllQuery, GetproclkdetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproclkdetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproclkdetailLoadAllListVm> Handle(GetproclkdetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<lkdetail> proclkdetails = await _procedureAdabter
               .Execute<lkdetail>("[FINA].[proc_lkdetailLoadAll]");
            GetproclkdetailLoadAllListVm vm = new GetproclkdetailLoadAllListVm
            {
                proclkdetails = _mapper.Map<IList<lkdetail>, IList<GetproclkdetailLoadAllVm>>(proclkdetails)
            };

            return vm;
        }
    }
}
