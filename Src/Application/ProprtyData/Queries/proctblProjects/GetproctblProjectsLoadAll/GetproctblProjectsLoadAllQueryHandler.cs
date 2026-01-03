using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.proctblProjects.GetproctblProjectsLoadAll
{
    class GetproctblProjectsLoadAllQueryHandler : IRequestHandler<GetproctblProjectsLoadAllQuery, GetproctblProjectsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblProjectsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblProjectsLoadAllListVm> Handle(GetproctblProjectsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblProjects> proctblProjectss = await _procedureAdabter
               .Execute<tblProjects>("[ProprtyData].[proc_tblProjectsLoadAll]");
            GetproctblProjectsLoadAllListVm vm = new GetproctblProjectsLoadAllListVm
            {
                proctblProjectss = _mapper.Map<IList<tblProjects>, IList<GetproctblProjectsLoadAllVm>>(proctblProjectss)
            };

            return vm;
        }
    }
}
