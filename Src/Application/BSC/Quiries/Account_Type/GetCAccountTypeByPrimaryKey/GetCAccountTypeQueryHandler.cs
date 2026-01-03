using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.Account_Type.GetCAccountTypeLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Account_Type.GetCAccountTypeByPrimaryKey
{
    public class GetCAccountTypeQueryHandler : IRequestHandler<GetCAccountTypeByPrimaryKey, GetCAccountTypeLoadAllListVm>
    {

        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCAccountTypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCAccountTypeLoadAllListVm> Handle(GetCAccountTypeByPrimaryKey request, CancellationToken cancellationToken)
        {
            long Id = request.Id;
            IList<Proc_C_Account_Type> accountTypes = await _procedureAdabter
               .Execute<Proc_C_Account_Type>("[BSC].[proc_c_Account_TypeLoadByPrimaryKey]", (nameof(Id), Id));
            GetCAccountTypeLoadAllListVm vm = new GetCAccountTypeLoadAllListVm
            {
                AccountTypes = _mapper.Map<IList<Proc_C_Account_Type>, IList<GetCAccountTypeLoadAllVm>>(accountTypes)
            };

            return vm;
        }
    }
}
