using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procDepreciation_Book.GetprocDepreciation_BookLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procDepreciation_Book.GetprocDepreciation_BookByPrimaryKey
{
    public class GetprocDepreciation_BookQueryHandler : IRequestHandler<GetprocDepreciation_BookByPrimaryKey, GetprocDepreciation_BookLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocDepreciation_BookQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDepreciation_BookLoadAllListVm> Handle(GetprocDepreciation_BookByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Depreciation_Book> procDepreciation_Books = await _procedureAdabter
               .Execute<Depreciation_Book>("[FINA].[proc_Depreciation_BookLoadByPrimaryKey]", request);
            GetprocDepreciation_BookLoadAllListVm vm = new GetprocDepreciation_BookLoadAllListVm
            {
                procDepreciation_Books = _mapper.Map<IList<Depreciation_Book>, IList<GetprocDepreciation_BookLoadAllVm>>(procDepreciation_Books)
            };

            return vm;
        }
    }
}
