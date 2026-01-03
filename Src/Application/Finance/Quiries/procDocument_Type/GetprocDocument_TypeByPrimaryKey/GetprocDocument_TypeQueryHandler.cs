using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procDocument_Type.GetprocDocument_TypeLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procDocument_Type.GetprocDocument_TypeByPrimaryKey
{
    public class GetprocDocument_TypeQueryHandler : IRequestHandler<GetprocDocument_TypeByPrimaryKey, GetprocDocument_TypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocDocument_TypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocDocument_TypeLoadAllListVm> Handle(GetprocDocument_TypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<DocumentType> procDocument_Types = await _procedureAdabter
               .Execute<DocumentType>("[FINA].[Document_TypeLoadByPrimaryKey]", request);
            GetprocDocument_TypeLoadAllListVm vm = new GetprocDocument_TypeLoadAllListVm
            {
                procDocument_Types = _mapper.Map<IList<DocumentType>, IList<GetprocDocument_TypeLoadAllVm>>(procDocument_Types)
            };

            return vm;
        }
    }
}
