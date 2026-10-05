using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowHub.DAL.Documents
{
    public class Company
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public DateTime RegisteredAt { get; set; }
    }
}
