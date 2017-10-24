using System;
using System.Collections.Generic;
using DataClasses;
using Codenut.ContractManager.Data.Handling;

namespace Codenut.ContractManager.Data.Handling
{
    public class Repository
    {
        IRepository _repository;

        public string RepositoryType { get; set; }

        public Contract GetContract()
        {
            throw new NotImplementedException();
        }

        public List<Contract> GetContracts(ContractFilter pContractFilter)
        {

            //If Debug then
            var dataFactory = new RepositoryFactory();
            _repository = dataFactory.CreateDataRepository("Dummy");

            return _repository.GetContracts(pContractFilter);
        }
    }
}
