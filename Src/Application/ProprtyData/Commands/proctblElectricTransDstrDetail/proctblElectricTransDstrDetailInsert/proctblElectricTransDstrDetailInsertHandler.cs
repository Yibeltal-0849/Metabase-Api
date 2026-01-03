



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblElectricTransDstrDetail.proctblElectricTransDstrDetailInsert.proctblElectricTransDstrDetailInsertCommand
{

    /// @author  Shimels Alem  proc_tblElectric_Trans_Dstr_DetailInsert stored procedure.


    public class proctblElectricTransDstrDetailInsertHandler : IRequestHandler<proctblElectricTransDstrDetailInsertCommand, IList<tblElectricTransDstrDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblElectricTransDstrDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblElectricTransDstrDetail_id>> Handle( proctblElectricTransDstrDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblElectricTransDstrDetail_id> result = await _procedureAdabter
                .Execute<tblElectricTransDstrDetail_id>("[ProprtyData].proc_tblElectric_Trans_Dstr_DetailInsert", request);
           

            return result;
        }
    }
}
 