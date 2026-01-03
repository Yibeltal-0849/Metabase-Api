

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblElectricTransDstrDetail.proctblElectricTransDstrDetailUpdate.proctblElectricTransDstrDetailUpdateCommand
{

    /// @author  Shimels Alem  proc_tblElectric_Trans_Dstr_DetailUpdate stored procedure.


    public class proctblElectricTransDstrDetailUpdateHandler : IRequestHandler<proctblElectricTransDstrDetailUpdateCommand, IList<tblElectricTransDstrDetail_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblElectricTransDstrDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblElectricTransDstrDetail_id>> Handle( proctblElectricTransDstrDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblElectricTransDstrDetail_id> result = await _procedureAdabter
                .Execute<tblElectricTransDstrDetail_id>("[ProprtyData].proc_tblElectric_Trans_Dstr_DetailUpdate", request);
           

            return result;
        }
    }
}
 