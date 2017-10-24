using System;
using System.Collections.Generic;
using Codenut.ContractManager.CrossCutting.BusinessObjects;
using Codenut.ContractManager.Data.Handling;

namespace Codenut.ContractManager.Data.Handling
{
    public class Repository 
    {
        Handling.IContractRepository _contractRepository;

        public Contract GetContract()
        {
            throw new NotImplementedException();
        }

        public List<Contract> GetContracts(ContractFilter pContractFilter)
        {

            //If Debug then
            var dataFactory = new RepositoryFactory();
            _contractRepository = dataFactory.CreateDataRepositoryFactory(RepositoryTypes.RepositoryType.Debug);

            return _contractRepository.GetContracts(pContractFilter);
        }
    }
}
