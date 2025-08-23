using GNN_DAL.Entities;
using GNN_DAL.Repos;
using GNN_DAL.Shared;

namespace GNN_Logic.Services
{
    public class CategoryService
    {
        private readonly CategoryRepo _categoryRepo;

        public CategoryService(CategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public async Task<PaginatedResult<Category>> GetCategoriesAsync(int pageNumber, int pageSize)
        {
            if(pageNumber <= 0) pageNumber = 1;
            if(pageSize <= 0) pageSize = 10;

            return await _categoryRepo.GetCategoriesAsync(pageNumber, pageSize);
        }
    }
}
