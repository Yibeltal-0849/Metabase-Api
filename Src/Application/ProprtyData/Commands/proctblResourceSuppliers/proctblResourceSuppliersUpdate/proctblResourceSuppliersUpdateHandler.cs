

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblResourceSuppliers.proctblResourceSuppliersUpdate.proctblResourceSuppliersUpdateCommand
{

    /// @author  Shimels Alem  proc_tblResourceSuppliersUpdate stored procedure.


    public class proctblResourceSuppliersUpdateHandler : IRequestHandler<proctblResourceSuppliersUpdateCommand, IList<tblResourceSuppliers_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceSuppliersUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceSuppliers_id>> Handle( proctblResourceSuppliersUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceSuppliers_id> result = await _procedureAdabter
                .Execute<tblResourceSuppliers_id>("[ProprtyData].proc_tblResourceSuppliersUpdate", request);
           

            return result;
        }
    }
}
 