using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLGLRegisters.GetprocLGLRegistersLoadAll
{
    class GetprocLGLRegistersLoadAllQueryHandler : IRequestHandler<GetprocLGLRegistersLoadAllQuery, GetprocLGLRegistersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLGLRegistersLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLGLRegistersLoadAllListVm> Handle(GetprocLGLRegistersLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<LGLRegisters> procLGLRegisterss = await _procedureAdabter
               .Execute<LGLRegisters>("[FINA].[proc_L_G_L_RegistersLoadAll]");
            GetprocLGLRegistersLoadAllListVm vm = new GetprocLGLRegistersLoadAllListVm
            {
                procLGLRegisterss = _mapper.Map<IList<LGLRegisters>, IList<GetprocLGLRegistersLoadAllVm>>(procLGLRegisterss)
            };

            return vm;
        }
    }
}
