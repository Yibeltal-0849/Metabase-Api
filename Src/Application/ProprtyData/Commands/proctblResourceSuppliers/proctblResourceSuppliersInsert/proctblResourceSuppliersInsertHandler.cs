



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResourceSuppliers.proctblResourceSuppliersInsert.proctblResourceSuppliersInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceSuppliersInsert stored procedure.


    public class proctblResourceSuppliersInsertHandler : IRequestHandler<proctblResourceSuppliersInsertCommand, IList<tblResourceSuppliers_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceSuppliersInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceSuppliers_id>> Handle( proctblResourceSuppliersInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceSuppliers_id> result = await _procedureAdabter
                .Execute<tblResourceSuppliers_id>("[ProprtyData].proc_tblResourceSuppliersInsert", request);
           

            return result;
        }
    }
}
 