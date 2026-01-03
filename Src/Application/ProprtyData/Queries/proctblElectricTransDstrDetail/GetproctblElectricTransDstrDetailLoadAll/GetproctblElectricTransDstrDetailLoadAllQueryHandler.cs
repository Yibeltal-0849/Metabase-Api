using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblElectricTransDstrDetail.GetproctblElectricTransDstrDetailLoadAll
{
    class GetproctblElectricTransDstrDetailLoadAllQueryHandler : IRequestHandler<GetproctblElectricTransDstrDetailLoadAllQuery, GetproctblElectricTransDstrDetailLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblElectricTransDstrDetailLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblElectricTransDstrDetailLoadAllListVm> Handle(GetproctblElectricTransDstrDetailLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblElectricTransDstrDetail> proctblElectricTransDstrDetails = await _procedureAdabter
               .Execute<tblElectricTransDstrDetail>("[ProprtyData].[proc_tblElectric_Trans_Dstr_DetailLoadAll]");
            GetproctblElectricTransDstrDetailLoadAllListVm vm = new GetproctblElectricTransDstrDetailLoadAllListVm
            {
                proctblElectricTransDstrDetails = _mapper.Map<IList<tblElectricTransDstrDetail>, IList<GetproctblElectricTransDstrDetailLoadAllVm>>(proctblElectricTransDstrDetails)
            };

            return vm;
        }
    }
}
