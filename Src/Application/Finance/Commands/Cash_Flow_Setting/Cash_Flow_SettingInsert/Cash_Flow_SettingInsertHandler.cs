



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.Cash_Flow_Setting.Cash_Flow_SettingInsert.Cash_Flow_SettingInsertCommand
{

    /// @author  Shimels Alem  c_Account_CatInsert stored procedure.


    public class Cash_Flow_SettingInsertHandler : IRequestHandler<Cash_Flow_SettingInsertCommand, IList<Cash_Flow_Setting_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public Cash_Flow_SettingInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Cash_Flow_Setting_Code>> Handle( Cash_Flow_SettingInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Cash_Flow_Setting_Code> result = await _procedureAdabter
                .Execute<Cash_Flow_Setting_Code>("[FINA].[proc_Cash_Flow_SettingInsert]", request);
           

            return result;
        }
    }
}
 