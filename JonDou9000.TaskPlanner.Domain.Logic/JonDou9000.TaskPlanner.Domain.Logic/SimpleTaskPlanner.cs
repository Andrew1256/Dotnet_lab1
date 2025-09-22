using JonDou9000.TaskPlanner.Domain.Models;
using System;
using System.Linq;

namespace JonDou9000.TaskPlanner.Domain.Logic
{
    public class SimpleTaskPlanner
    {
        public WorkItem[] CreatePlan(WorkItem[] items)
        {
            return items
                .OrderByDescending(x => x.Priority)   // 1. Пріоритет (High > Medium > Low)
                .ThenBy(x => x.DueDate)               // 2. Дата дедлайну (раніше — перше)
                .ThenBy(x => x.Title)                 // 3. Алфавітний порядок
                .ToArray();
        }
    }
}
