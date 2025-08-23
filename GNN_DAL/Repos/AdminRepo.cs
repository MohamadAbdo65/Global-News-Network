using GNN_DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GNN_DAL.Repos
{
    public class AdminRepo
    {
        private readonly GNNDbContext _context;

        public AdminRepo(GNNDbContext context)
        {
            _context = context;
        }

    }
}
