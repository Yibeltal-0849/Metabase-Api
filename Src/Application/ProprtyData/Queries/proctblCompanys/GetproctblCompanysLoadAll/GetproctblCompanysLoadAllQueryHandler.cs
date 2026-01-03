using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.proctblCompanys.GetproctblCompanysLoadAll
{
    class GetproctblCompanysLoadAllQueryHandler : IRequestHandler<GetproctblCompanysLoadAllQuery, GetproctblCompanysLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblCompanysLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblCompanysLoadAllListVm> Handle(GetproctblCompanysLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblCompanys> proctblCompanyss = await _procedureAdabter
               .Execute<tblCompanys>("[ProprtyData].[proc_tblCompanysLoadAll]");
            GetproctblCompanysLoadAllListVm vm = new GetproctblCompanysLoadAllListVm
            {
                proctblCompanyss = _mapper.Map<IList<tblCompanys>, IList<GetproctblCompanysLoadAllVm>>(proctblCompanyss)
            };

            return vm;
        }
    }
}
