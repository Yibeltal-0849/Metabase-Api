using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.dbo.Quiries.procProperty_Document.GetprocProperty_DocumentLoadAll;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;

namespace Application.dbo.Quiries.procProperty_Document.GetprocProperty_DocumentLoadByPrimaryKey_FIXEDAssetNO
{
    public class GetprocProperty_DocumentQueryHandler : IRequestHandler<GetprocProperty_DocumentLoadByPrimaryKey_FIXEDAssetNO, GetprocProperty_DocumentLoadAllListVm2>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocProperty_DocumentQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocProperty_DocumentLoadAllListVm2> Handle(GetprocProperty_DocumentLoadByPrimaryKey_FIXEDAssetNO request, CancellationToken cancellationToken)
        {
           
            IList<Property_Document> procProperty_Documents = await _procedureAdabter
               .Execute<Property_Document>("[dbo].[proc_Property_DocumentLoadByPrimaryKey]", request);
            GetprocProperty_DocumentLoadAllListVm2 vm = new GetprocProperty_DocumentLoadAllListVm2
            {
                procProperty_Documents = _mapper.Map<IList<Property_Document>, IList<GetprocProperty_DocumentLoadAllVm2>>(procProperty_Documents)
            };

            return vm;
        }
    }
}
