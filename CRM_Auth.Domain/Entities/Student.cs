
using Microsoft.AspNetCore.Identity;

namespace CRM_Auth.Domain.Entities
{

    public class Student : IdentityUser
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CourseId { get; set; } = Guid.NewGuid();
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string? ImagePath { get; set; }
        public string? Results_ImagePath { get; set; }
        public string Feedback { get; set; }
    }
}
