using Scholaris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scholaris.Services
{
    interface ICategory
    {
        IEnumerable<Category> GetCategories { get; }
        Category GetCategory(int? Id);
        void Add(Category _Category);
        void Remove(int? Id);
    }
}
