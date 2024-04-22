using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Auth.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

    }
}
