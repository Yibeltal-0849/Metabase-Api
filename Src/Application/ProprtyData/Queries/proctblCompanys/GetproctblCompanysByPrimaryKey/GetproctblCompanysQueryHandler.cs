using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Quiries.proctblCompanys.GetproctblCompanysLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.proctblCompanys.GetproctblCompanysByPrimaryKey
{
    public class GetproctblCompanysQueryHandler : IRequestHandler<GetproctblCompanysByPrimaryKey, GetproctblCompanysLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblCompanysQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblCompanysLoadAllListVm> Handle(GetproctblCompanysByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblCompanys> proctblCompanyss = await _procedureAdabter
               .Execute<tblCompanys>("[ProprtyData].[proc_tblCompanysLoadByPrimaryKey]", request);
            GetproctblCompanysLoadAllListVm vm = new GetproctblCompanysLoadAllListVm
            {
                proctblCompanyss = _mapper.Map<IList<tblCompanys>, IList<GetproctblCompanysLoadAllVm>>(proctblCompanyss)
            };

            return vm;
        }
    }
}
