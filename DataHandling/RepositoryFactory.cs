using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using Ninject; 
using Ninject.Extensions.Conventions;

namespace Codenut.ContractManager.Data.Handling
{
    public class RepositoryFactory
    {
        private readonly IEnumerable<IRepository> _reposistories;

        public RepositoryFactory()
        {

            //var kernel = new StandardKernel();
            //kernel.Bind(x => x.FromAssembliesInPath(".", a => a.FullName.Contains("Repository")).SelectAllClasses().BindDefaultInterface());
            
            //IRepository test = kernel.Get<IRepository>();
        }

        public IRepository CreateDataRepository(string pRepositoryType)
        {


            switch(pRepositoryType)
                "": return new Repository();                                                                    

            return _reposistories.Single(r => r.RepositoryType == pRepositoryType);
        }
    }
}
