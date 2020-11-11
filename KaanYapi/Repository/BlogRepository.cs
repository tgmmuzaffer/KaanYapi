using KaanYapi.Data;
using KaanYapi.Models;
using KaanYapi.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KaanYapi.Repository
{
    public class BlogRepository :IBlogRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BlogRepository(ApplicationDbContext dbContext)
        {
            _dbContext= dbContext;
        }

        public bool CreateAsync(BlogModel objtoCreate)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAsync(BlogModel objtoCreate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogModel> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public BlogModel GetAsync(int Id)
        {
            return _dbContext.Blogs.FirstOrDefault(b => b.Id == Id);
        }

        public bool UpdateAsync(BlogModel objtoCreate)
        {
            throw new NotImplementedException();
        }
    }
}
