using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceSuppliers.GetproctblResourceSuppliersLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceSuppliers.GetproctblResourceSuppliersByPrimaryKey
{
    public class GetproctblResourceSuppliersQueryHandler : IRequestHandler<GetproctblResourceSuppliersByPrimaryKey, GetproctblResourceSuppliersLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceSuppliersQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceSuppliersLoadAllListVm> Handle(GetproctblResourceSuppliersByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceSuppliers> proctblResourceSupplierss = await _procedureAdabter
               .Execute<tblResourceSuppliers>("[ProprtyData].[proc_tblResourceSuppliersLoadByPrimaryKey]", request);
            GetproctblResourceSuppliersLoadAllListVm vm = new GetproctblResourceSuppliersLoadAllListVm
            {
                proctblResourceSupplierss = _mapper.Map<IList<tblResourceSuppliers>, IList<GetproctblResourceSuppliersLoadAllVm>>(proctblResourceSupplierss)
            };

            return vm;
        }
    }
}
