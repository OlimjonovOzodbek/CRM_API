using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Auth.Application.Abstractions
{
    public interface IApplicationDbContext
    {
        ValueTask<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
