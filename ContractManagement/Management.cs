
using System.Collections.Generic;
using Codenut.ContractManager.Data.Handling;
using DataClasses;

namespace Codenut.ContractManager.Logic.ContractManagement
{
    public class Management
    {
        Repository _contractRepository;

        public Contract QueryContract()
        {
            _contractRepository = new Data.Handling.Repository();
            return _contractRepository.GetContract();
        }

        public List<Contract> QueryContracts(ContractFilter pContractFilter)
        {
            _contractRepository = new Data.Handling.Repository();
            return _contractRepository.GetContracts(pContractFilter);
        }

        public void InsertContract()
        { }

        public void DeleteContract()
        { }


    }
}
