using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing
{
    public class TaskCycle
    {
        private int _seeder = 0;
        private List<Task> _tasks;
        private Enumeration.TaskType _taskType;
        private DateTime _startDate;
        private DateTime _endDate;  
        private int _interval;
        
        public List<Task> Tasks => _tasks;
        public DateTime StartDate => _startDate;        
        public DateTime EndDate => _endDate;
        public Enumeration.TaskType TaskType => _taskType;
        public int Interval => _interval;

        public TaskCycle(DateTime startDate, DateTime endDate, int interval, Enumeration.TaskType type)
        {
            _tasks = new List<Task>();
            _taskType = type;
            _startDate = startDate;
            _endDate = endDate;
            _interval = interval;
            _seeder++;
        }

        public TaskCycle()
        {

        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }
    }
}

