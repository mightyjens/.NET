using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codenut.ContractManager.Data.DataFactory
{
    public class DataRepositoryFactory
    {

        public Interfaces.IContractRepository CreateDataRepositoryFactory()
        {
            return new DataHandling.ContractRepositorySQL();
        }


    }
}
