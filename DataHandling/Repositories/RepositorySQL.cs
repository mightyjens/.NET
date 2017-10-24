using Codenut.ContractManager.CrossCutting.BusinessObjects;
using System.Collections.Generic;

namespace Codenut.ContractManager.Data.Handling
{
    class RepositorySQL : Data.Handling.IContractRepository
    {

        public Contract GetContract()
        {
            return new Contract();
        }

        public List<Contract> GetContracts(ContractFilter pContractFilter)
        {
            return new List<Contract>();
        }
    }
}
