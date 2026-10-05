using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowHub.DAL.Documents
{
    public class Task
    {
        public Guid Id { get; set; }

        public Guid SprintId { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public DateTime Created { get; set; }

        public required string Priority { get; set; }

        public required string Type { get; set; }

        public required string Status { get; set; }

        public IEnumerable<PeriodicReport?> PeriodicReports { get; set; } = Enumerable.Empty<PeriodicReport>();

        public IEnumerable<Comment?> Comments { get; set; } = Enumerable.Empty<Comment>();

        public IEnumerable<Task?> Tasks { get; set; }
    }

    public class PeriodicReport
    {
        public DateTime Created { get; set; }

        public string? Descriprion { get; set; }

        public required string Status { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public Guid UserId { get; set; }
    }

    public class Comment
    {
        public Guid UserId { get; set; }

        public required string Type { get; set; }

        public required string Description { get; set; }

        public DateTime Created { get; set; }
    }
}