using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CRM_Auth.Domain.Entities;
using System.Threading.Tasks;
 

namespace CRM_Auth.Application.useCases.Lessons.Commands
{
    public class LessonCreateCommand
    {
        public string Title {  get; set; }
        public string VideoPath { get; set; }
    }
}
