using Autofac;
using Business.Abstract;
using Business.Concrate;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrate;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            CategoryDepencyInj(builder);
        }

        private void CategoryDepencyInj(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
        }
    }
}
