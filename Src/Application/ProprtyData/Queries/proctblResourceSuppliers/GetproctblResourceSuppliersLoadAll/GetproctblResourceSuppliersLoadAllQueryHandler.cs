using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceSuppliers.GetproctblResourceSuppliersLoadAll
{
    class GetproctblResourceSuppliersLoadAllQueryHandler : IRequestHandler<GetproctblResourceSuppliersLoadAllQuery, GetproctblResourceSuppliersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblResourceSuppliersLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceSuppliersLoadAllListVm> Handle(GetproctblResourceSuppliersLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblResourceSuppliers> proctblResourceSupplierss = await _procedureAdabter
               .Execute<tblResourceSuppliers>("[ProprtyData].[proc_tblResourceSuppliersLoadAll]");
            GetproctblResourceSuppliersLoadAllListVm vm = new GetproctblResourceSuppliersLoadAllListVm
            {
                proctblResourceSupplierss = _mapper.Map<IList<tblResourceSuppliers>, IList<GetproctblResourceSuppliersLoadAllVm>>(proctblResourceSupplierss)
            };

            return vm;
        }
    }
}
