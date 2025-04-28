using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GStock.Data.Operations
{
    public class GenericRepository<TEntity> 
    {
 
        public GenericRepository() {
            var context = new StockDbContext();
        }

        public GenericRepository(TEntity entity) { }

        ////////


    }
}
