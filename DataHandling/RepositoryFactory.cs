
namespace Codenut.ContractManager.Data.Handling
{
    public class RepositoryFactory
    {
        public Handling.IContractRepository CreateDataRepositoryFactory(RepositoryTypes.RepositoryType pRepositoryType)
        {
            switch(pRepositoryType)
            {
                case RepositoryTypes.RepositoryType.SQL:
                    {
                        return new RepositorySQL();
                    }
                    break;
                default:
                    {
                        return new RepositoryDummy();
                    }
            }
            
        }
    }
}
