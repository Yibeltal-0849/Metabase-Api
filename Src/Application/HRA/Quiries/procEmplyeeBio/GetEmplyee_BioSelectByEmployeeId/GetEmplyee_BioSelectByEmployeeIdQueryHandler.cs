using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procEmplyeeBio.GetprocEmplyeeBioLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procEmplyeeBio.GetEmplyee_BioSelectByEmployeeId
{
    public class GetEmplyee_BioSelectByEmployeeIdQueryHandler : IRequestHandler<GetEmplyee_BioSelectByEmployeeId, GetprocEmplyeeBioLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetEmplyee_BioSelectByEmployeeIdQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmplyeeBioLoadAllListVm> Handle(GetEmplyee_BioSelectByEmployeeId request, CancellationToken cancellationToken)
        {
           
            IList<EmplyeeBio> procEmplyeeBios = await _procedureAdabter
               .Execute<EmplyeeBio>("[HRA].[usp_Emplyee_BioSelectByEmployeeId]", request);
            GetprocEmplyeeBioLoadAllListVm vm = new GetprocEmplyeeBioLoadAllListVm
            {
                procEmplyeeBios = _mapper.Map<IList<EmplyeeBio>, IList<GetprocEmplyeeBioLoadAllVm>>(procEmplyeeBios)
            };

            return vm;
        }
    }
}
