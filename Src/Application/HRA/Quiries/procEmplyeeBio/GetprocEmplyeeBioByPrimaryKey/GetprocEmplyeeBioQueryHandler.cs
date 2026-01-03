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

namespace Application.HRA.Quiries.procEmplyeeBio.GetprocEmplyeeBioByPrimaryKey
{
    public class GetprocEmplyeeBioQueryHandler : IRequestHandler<GetprocEmplyeeBioByPrimaryKey, GetprocEmplyeeBioLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocEmplyeeBioQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocEmplyeeBioLoadAllListVm> Handle(GetprocEmplyeeBioByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<EmplyeeBio> procEmplyeeBios = await _procedureAdabter
               .Execute<EmplyeeBio>("[HRA].[proc_Emplyee_BioLoadByPrimaryKey]", request);
            GetprocEmplyeeBioLoadAllListVm vm = new GetprocEmplyeeBioLoadAllListVm
            {
                procEmplyeeBios = _mapper.Map<IList<EmplyeeBio>, IList<GetprocEmplyeeBioLoadAllVm>>(procEmplyeeBios)
            };

            return vm;
        }
    }
}
