using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Quiries.proctblProjects.GetproctblProjectsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Quiries.proctblProjects.GetproctblProjectsByPrimaryKey
{
    public class GetproctblProjectsQueryHandler : IRequestHandler<GetproctblProjectsByPrimaryKey, GetproctblProjectsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblProjectsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblProjectsLoadAllListVm> Handle(GetproctblProjectsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblProjects> proctblProjectss = await _procedureAdabter
               .Execute<tblProjects>("[ProprtyData].[proc_tblProjectsLoadByPrimaryKey]", request);
            GetproctblProjectsLoadAllListVm vm = new GetproctblProjectsLoadAllListVm
            {
                proctblProjectss = _mapper.Map<IList<tblProjects>, IList<GetproctblProjectsLoadAllVm>>(proctblProjectss)
            };

            return vm;
        }
    }
}
