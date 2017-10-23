using static Codenut.ContractManager.Data.DataHandling.RepositoryTypes;

namespace Codenut.ContractManager.Data.DataHandling
{
    public class ContractRepositoryFactory
    {
        public Interfaces.IContractRepository CreateDataRepositoryFactory(RepositoryType pRepositoryType)
        {
            switch(pRepositoryType)
            {
                case RepositoryType.SQL:
                    {
                        return new ContractRepositorySQL();
                    }
                    break;
                default:
                    {
                        return new ContractRepositoryDummy();
                    }
            }
            
        }
    }
}
