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
        private readonly GlobalNewsNetworkContext _context;

        public AdminRepo(GlobalNewsNetworkContext context)
        {
            _context = context;
        }

    }
}
