using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procorganizationsDelete.procorganizationsDeleteCommand
{

    /// @author  Henok Solomon  proc_organizationsDelete stored procedure.


    public class procorganizationsDeleteHandler : IRequestHandler<procorganizationsDeleteCommand, IList<procorganizations_organization_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public procorganizationsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procorganizations_organization_Code>> Handle(procorganizationsDeleteCommand request, CancellationToken cancellationToken)
        {
            return await _procedureAdabter.Execute<procorganizations_organization_Code>(
                "[dbo].proc_organizationsDelete", request);
        }
    }



}

