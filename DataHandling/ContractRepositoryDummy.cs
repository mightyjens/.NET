using Codenut.ContractManager.CrossCutting.BusinessObjects;
using System.Collections.Generic;

namespace Codenut.ContractManager.Data.DataHandling
{
    class ContractRepositoryDummy : Data.Interfaces.IContractRepository
    {

        public Contract GetContract()
        {
            return new Contract();
        }

        public List<Contract> GetContracts(ContractFilter pContractFilter)
        {
            var _contractList = new List<Contract>();
            _contractList.Add(new Contract
            {
                Id = 16
            });

            return _contractList;
        }
    }
}
