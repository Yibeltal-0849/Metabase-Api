using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblStackHolder.GetproctblStackHolderLoadAll
{
    class GetproctblStackHolderLoadAllQueryHandler : IRequestHandler<GetproctblStackHolderLoadAllQuery, GetproctblStackHolderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblStackHolderLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblStackHolderLoadAllListVm> Handle(GetproctblStackHolderLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblStackHolder> proctblStackHolders = await _procedureAdabter
               .Execute<tblStackHolder>("[ProprtyData].[proc_tblStackHolderLoadAll]");
            GetproctblStackHolderLoadAllListVm vm = new GetproctblStackHolderLoadAllListVm
            {
                proctblStackHolders = _mapper.Map<IList<tblStackHolder>, IList<GetproctblStackHolderLoadAllVm>>(proctblStackHolders)
            };

            return vm;
        }
    }
}
