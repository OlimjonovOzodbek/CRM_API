using CRM_Auth.Domain.Entities;
using MediatR;

namespace CRM_Auth.Application.useCases.Comments.Command
{
    public class CreateCommentCommand : IRequest<Comment>
    {
        public string? Message { get; set; }
        public Guid LessonId { get; set; }
        public Guid UserId { get; set; }
    }
}
