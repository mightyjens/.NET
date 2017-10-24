using System.Collections.Generic;
using System.ComponentModel.Composition;
using DataClasses;

namespace Codenut.ContractManager.Data.Handling
{
    class RepositorySql : IRepository
    {
        public string RepositoryType { get; set; }

        public RepositorySql(IRepository repository)
        {
            RepositoryType = "SQL";
        }

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
