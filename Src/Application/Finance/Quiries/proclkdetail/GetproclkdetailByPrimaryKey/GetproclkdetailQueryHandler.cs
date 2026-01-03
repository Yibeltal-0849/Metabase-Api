using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proclkdetail.GetproclkdetailLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proclkdetail.GetproclkdetailByPrimaryKey
{
    public class GetproclkdetailQueryHandler : IRequestHandler<GetproclkdetailByPrimaryKey, GetproclkdetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproclkdetailQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproclkdetailLoadAllListVm> Handle(GetproclkdetailByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<lkdetail> proclkdetails = await _procedureAdabter
               .Execute<lkdetail>("[FINA].[proc_lkdetailLoadByPrimaryKey]", request);
            GetproclkdetailLoadAllListVm vm = new GetproclkdetailLoadAllListVm
            {
                proclkdetails = _mapper.Map<IList<lkdetail>, IList<GetproclkdetailLoadAllVm>>(proclkdetails)
            };

            return vm;
        }
    }
}
