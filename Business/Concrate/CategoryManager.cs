using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CategoryManager : ICategoryService
    {   
        private ICategoryDal _categoryDal ;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.CategoryAdded);
        }

        public IResult Delete(Category category)
        {
            
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.CategoryDeleted);

        }



        public IDataResult<Category> GetCategoryById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c=>c.CategoryId==id));
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList());
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.CategoryUpdate);

        }
    }
}
