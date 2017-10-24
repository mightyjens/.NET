using DataClasses;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Codenut.ContractManager.Data.Handling;

namespace Codenut.ContractManager.Data.Handling
{
    class RepositoryDummy : IRepository
    {
        public string RepositoryType { get; set; }

        public RepositoryDummy(IRepository repository)
        {
            RepositoryType = "Dummy";
        }

        public Contract GetContract()
        {
            return new Contract();
        }

        public List<Contract> GetContracts(ContractFilter pContractFilter)
        {
            var contractList = new List<Contract>();
            contractList.Add(new Contract
            {
                Id = 16
            });

            return contractList;
        }
    }
}
