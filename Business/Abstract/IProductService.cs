using Core.Utilities.Results;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int ProductId);
        IDataResult<List<Product>> GetAll();

        IDataResult<List<Product>> GetByCategory(int categoryId);

        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);



    }
}
