using GNN_DAL.Data;
using GNN_DAL.Entities;
using GNN_DAL.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNN_DAL.Repos
{
    public class CategoryRepo
    {
        private readonly GNNDbContext _context;

        public CategoryRepo(GNNDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResult<Category>> GetCategoriesAsync(int pageNumber , int pageSize)
        {
            return await _context.Categories
                .AsNoTracking()
                .ToPaginatedListAsync(pageNumber, pageSize);
        }

    }
}
