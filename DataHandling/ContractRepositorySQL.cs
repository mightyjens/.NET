using Codenut.ContractManager.CrossCutting.BusinessObjects;
using System.Collections.Generic;

namespace Codenut.ContractManager.Data.DataHandling
{
    class ContractRepositorySQL : Data.Interfaces.IContractRepository
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
