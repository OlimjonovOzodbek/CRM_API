﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Auth.Application.useCases.Comment.Command
{
    public class UpdateCommentCommand
    {
        public Guid Id { get; set; }
        public string? Message { get; set; }
    }
}
