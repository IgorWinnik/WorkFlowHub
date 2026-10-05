using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowHub.DAL.Documents
{
    public class Project
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? FinishedAt { get; set; }

        public required string Status { get; set; }
    }
}
