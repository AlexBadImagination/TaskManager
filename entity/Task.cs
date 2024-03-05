using System;

namespace Task_manager.entity
{
    public class Task
    {
        public string Name { get; }
        public string Description { get; }
        public DateTime Deadline { get; }
        public Status Status { get; }
        public int Priority { get; }

        public Task(string name, string description, DateTime deadline, Status status, int priority)
        {
            Name = name;
            Description = description;
            Deadline = deadline;
            Status = status;
            Priority = priority;
        }
    }
}