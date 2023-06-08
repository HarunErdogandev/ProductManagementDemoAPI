using Core.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal: EfEntityReporistoryBase<Product, NorthwindContext> ,IProductDal
    {

    }
}
