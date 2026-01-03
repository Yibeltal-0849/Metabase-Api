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

namespace Application.HRA.Quiries.procEmplyeeBio.Get_Emplyee_BioSelectByKeywordFromJsonBioData
{
    public class GetBioSelectByKeywordFromJsonBioDataQueryHandler : IRequestHandler<Get_Emplyee_BioSelectByKeywordFromJsonBioData, GetprocEmplyeeBioLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetBioSelectByKeywordFromJsonBioDataQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmplyeeBioLoadAllListVm> Handle(Get_Emplyee_BioSelectByKeywordFromJsonBioData request, CancellationToken cancellationToken)
        {
           
            IList<EmplyeeBio> procEmplyeeBios = await _procedureAdabter
               .Execute<EmplyeeBio>("[HRA].[usp_Emplyee_BioSelectByKeywordFromJsonBioData]", request);
            GetprocEmplyeeBioLoadAllListVm vm = new GetprocEmplyeeBioLoadAllListVm
            {
                procEmplyeeBios = _mapper.Map<IList<EmplyeeBio>, IList<GetprocEmplyeeBioLoadAllVm>>(procEmplyeeBios)
            };

            return vm;
        }
    }
}
