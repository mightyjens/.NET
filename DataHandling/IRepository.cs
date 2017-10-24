using Codenut.ContractManager.CrossCutting.BusinessObjects;
using System.Collections.Generic;

namespace Codenut.ContractManager.Data.Handling
{
    public interface IContractRepository
    {
        Contract GetContract();

        List<Contract> GetContracts(ContractFilter pContractFilter);
    }
}
