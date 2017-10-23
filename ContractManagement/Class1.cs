using Codenut.ContractManager.CrossCutting.BusinessObjects;
using Codenut.ContractManager.Data;
using System.Collections.Generic;

namespace Codenut.ContractManager.Logic.ContractManagement
{
    public class Class1
    {
        Data.DataHandling.ContractRepository _contractRepository;

        public Contract GetContract()
        {
            _contractRepository = new Data.DataHandling.ContractRepository();
            return _contractRepository.GetContract();
        }

        public List<Contract> GetContracts(ContractFilter pContractFilter)
        {
            _contractRepository = new Data.DataHandling.ContractRepository();
            return _contractRepository.GetContracts(pContractFilter);
        }
    }
}
