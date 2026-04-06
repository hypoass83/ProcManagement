using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface.Security;
using Domain.Entities.Security;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context.Repositories
{
    

    public class EmployeRepository : IEmployeRepository
    {
        private readonly AppDbContext _context;

        public EmployeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Employe> GetByUserId(string userId)
        {
            return await _context.Employe
                .FirstOrDefaultAsync(u => u.Matricule == userId);
        }
    }
}
