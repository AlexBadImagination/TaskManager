using System;

namespace Task_manager.entity
{
    public class Task
    {
        public int Id { get; private set; }
        private static int _nextId = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Status Status { get; set; }
        public int Priority { get; set; }

        public Task(string name, string description, DateTime deadline, Status status, int priority)
        {
            Id = _nextId++;
            Name = name;
            Description = description;
            Deadline = deadline;
            Status = status;
            Priority = priority;
        }

        public Task()
        {
            Id = _nextId++;
            Name = "Нове завдання";
            Deadline = DateTime.Today;
            Status = Status.Заплановано;
            Priority = 1;
        }

        public Task ShallowCopy()
        {
            return (Task) MemberwiseClone();
        }
    }
}