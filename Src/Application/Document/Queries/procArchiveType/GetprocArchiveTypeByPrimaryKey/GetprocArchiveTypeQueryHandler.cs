using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Document.Quiries.procArchiveType.GetprocArchiveTypeLoadAll;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Document.Quiries.procArchiveType.GetprocArchiveTypeByPrimaryKey
{
    public class GetprocArchiveTypeQueryHandler : IRequestHandler<GetprocArchiveTypeByPrimaryKey, GetprocArchiveTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocArchiveTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocArchiveTypeLoadAllListVm> Handle(GetprocArchiveTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Archive_Type> procArchiveTypes = await _procedureAdabter
               .Execute<Archive_Type>("[Document].[proc_Archive_TypeLoadByPrimaryKey]", request);
            GetprocArchiveTypeLoadAllListVm vm = new GetprocArchiveTypeLoadAllListVm
            {
                procArchiveTypes = _mapper.Map<IList<Archive_Type>, IList<GetprocArchiveTypeLoadAllVm>>(procArchiveTypes)
            };

            return vm;
        }
    }
}
