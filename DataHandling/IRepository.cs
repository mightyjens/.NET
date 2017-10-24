using DataClasses;
using System.Collections.Generic;

namespace Codenut.ContractManager.Data.Handling
{ 
    public interface IRepository
    {
        string RepositoryType { get; set; }
        Contract GetContract();

        List<Contract> GetContracts(ContractFilter pContractFilter);
    }
}
