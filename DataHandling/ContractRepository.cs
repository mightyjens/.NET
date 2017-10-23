using System;
using System.Collections.Generic;
using Codenut.ContractManager.CrossCutting.BusinessObjects;

namespace Codenut.ContractManager.Data.DataHandling
{
    public class ContractRepository 
    {
        Interfaces.IContractRepository _contractRepository;

        public Contract GetContract()
        {
            throw new NotImplementedException();
        }

        public List<Contract> GetContracts(ContractFilter pContractFilter)
        {

            //If Debug then
            var _dataFactory = new ContractRepositoryFactory();
            _contractRepository = _dataFactory.CreateDataRepositoryFactory(RepositoryTypes.RepositoryType.Debug);

            return _contractRepository.GetContracts(pContractFilter);
        }
    }
}
