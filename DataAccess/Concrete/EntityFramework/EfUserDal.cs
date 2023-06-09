﻿using Core.Concrete.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrate;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityReporistoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                try
                {
                    var result = from operationClaim in context.OperationClaims
                                 join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.Id
                                 where userOperationClaim.UserId == user.Id
                                 select new OperationClaim
                                 {
                                     Id = operationClaim.Id,
                                     Name = operationClaim.Name,
                                 };

                    return result.ToList();
                }
                catch (Exception ex)
                {
                    // Hata ayrıntılarını görüntüle
                    Console.WriteLine(ex.ToString());
                    throw; // Hata fırlat
                }
            }
        }
    }
}
