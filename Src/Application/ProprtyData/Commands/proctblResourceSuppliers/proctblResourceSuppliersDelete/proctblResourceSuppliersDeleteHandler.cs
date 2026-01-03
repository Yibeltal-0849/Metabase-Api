using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceSuppliers.proctblResourceSuppliersDelete.proctblResourceSuppliersDeleteCommand
{

    /// @author  Shimels Alem  proc_tblResourceSuppliersDelete stored procedure.


    public class proctblResourceSuppliersDeleteHandler : IRequestHandler<proctblResourceSuppliersDeleteCommand, IList<tblResourceSuppliers_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceSuppliersDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceSuppliers_id>> Handle( proctblResourceSuppliersDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceSuppliers_id> result = await _procedureAdabter
                .Execute<tblResourceSuppliers_id>("[ProprtyData].proc_tblResourceSuppliersDelete", request);
           

            return result;
        }
    }
}
  