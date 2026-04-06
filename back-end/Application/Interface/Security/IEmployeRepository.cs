using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Security;

namespace Application.Interface.Security
{
    public interface IEmployeRepository
    {
        Task<Employe> GetByUserId(string userId);
    }
}
