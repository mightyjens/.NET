using Codenut.ContractManager.CrossCutting.BusinessObjects;
using System.Collections.Generic;

namespace Codenut.ContractManager.Data.Interfaces
{
    public interface IContractRepository
    {
        Contract GetContract();

        List<Contract> GetContracts(ContractFilter pContractFilter);
    }
}
