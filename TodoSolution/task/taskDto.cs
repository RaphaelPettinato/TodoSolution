using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoSolution.task
{
    class taskDto
    {
        public required Guid Id { get; set; }
        public required string TaskName { get; set; }
        public required bool Completed { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime CompletedAt { get; set; }

        public override string ToString()
        {
            return $"{TaskName} - {(Completed ?  $"Completata alle {CompletedAt}" : $"Pendente - Creata alle {InsertedAt}")}";
        }
    }
}
