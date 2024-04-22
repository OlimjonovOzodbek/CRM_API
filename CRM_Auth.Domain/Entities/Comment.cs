using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Auth.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Message { get; set; }
        public Guid LessonId { get; set; }
        public Guid UserId { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual User User { get; set; }
    }
}
