using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Auth.Application.useCases.Comment.Command
{
    public class CreateCommentCommand
    {
        public string? Message { get; set; }
        public Guid LessonId { get; set; }
        public Guid UserId { get; set; }
    }
}
