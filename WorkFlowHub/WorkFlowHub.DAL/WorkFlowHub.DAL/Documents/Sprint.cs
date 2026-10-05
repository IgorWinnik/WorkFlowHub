using System;
using System.Collections.Generic;
using System.Text;

namespace WorkFlowHub.DAL.Documents
{
    public class Sprint
    {
        public Guid Id { get; set; }

        public Guid ProjectId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime StartAt {  get; set; }

        public DateTime FinishedAt { get; set; }

        public string Status { get; set; }
    }
}
