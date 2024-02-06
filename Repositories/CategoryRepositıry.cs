using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepositıry : RepositoryBase<Category>, ICategoryRepositıry
    {
        public CategoryRepositıry(RepositoryContext context) : base(context)
        {
            
        }
    }
}
