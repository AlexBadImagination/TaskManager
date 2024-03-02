using System;

namespace Task_manager.entity
{
    public class Task
    {
        public string Name { get; }
        public string Description { get; }
        public DateTime Deadline { get; }
        public Status Status { get; }

        public Task(string name, string description, DateTime deadline, Status status)
        {
            Name = name;
            Description = description;
            Deadline = deadline;
            Status = status;
        }
    }
}