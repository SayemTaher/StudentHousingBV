using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing
{
    public class StudentHouseManagement
    {
        private Property? _property;
        private User _student;
        List<Event>? _eventsOfStudent;
        private List<TaskCycle>? _taskCycles;
        private TaskCycle _trashCycle;
        private TaskCycle _cleanCycle;
        DateTime monday;

        public StudentHouseManagement(User student)
        {                   
            _student = student;
            _property = student.Property;
            _eventsOfStudent = new List<Event>();
            _taskCycles = new List<TaskCycle>();
            _taskCycles = TextFileUtilities.GetFromJson<TaskCycle>("Cycles");
            monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            _cleanCycle = new TaskCycle();
            _trashCycle = new TaskCycle();
            GenerateUpcomingTasks();
        }

        public Property? Property { get { return _property; } }

        public List<Event>? GetEventsOfStudent()
        {
            _eventsOfStudent = GetEvents()?.Where(x => x.Student.Id == _student.Id).ToList();
            return _eventsOfStudent;
        }

        public List<User>? GetAllStudents()
        {
            List<User> allStudents = TextFileUtilities.GetFromJson<User>("UsersData");
            return allStudents;
        }
        public List<Event>? GetEvents()
        {
            List<Event> _events = TextFileUtilities.GetFromJson<Event>("Events");
            return _events;
        }

        public TaskCycle GetCleanCycle()
        {
            return _cleanCycle;
        }

        public TaskCycle GetTrashCycle()
        {
            return _trashCycle;
        }

        private List<User> GetStudentsFromProperty()
        {
            List<User> housemates = new List<User>();
            foreach (var s in GetAllStudents()) 
            {
                if(_student.Property.Name == s.Property.Name)
                {
                    housemates.Add(s);
                }
            }
            return housemates;
        }

        private void GenerateUpcomingTasks()
        {
            if (GetCurrentCycle(_property, Enumeration.TaskType.CLEAN) == null)
            {
                _cleanCycle = GenerateTaskCycle(Enumeration.TaskType.CLEAN);              
            }
            if (GetCurrentCycle(_property, Enumeration.TaskType.TRASH) == null)
            {
                _trashCycle = GenerateTaskCycle(Enumeration.TaskType.TRASH);
            }
        }

        private TaskCycle? GetCurrentCycle(Property property, Enumeration.TaskType type)
        {
            DateTime today = DateTime.Today;
            foreach (var cycle in _taskCycles)
            {
                if (cycle.TaskType == type & cycle.StartDate <= today & today <= cycle.EndDate & property == _property)
                {
                    return cycle;
                }
            }
            return null;
        }

        private TaskCycle GenerateTaskCycle(Enumeration.TaskType type)
        {
            int interval = GetAllStudents().Count;
            TaskCycle cycle = new TaskCycle(monday, monday.AddDays(interval), interval, type);
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < GetAllStudents().Count; i++)
            {
                cycle.AddTask(new Task(GetAllStudents().ToArray()[i], monday.AddDays(i), cycle.TaskType));
            }
            _taskCycles.Add(cycle);
            TextFileUtilities.WriteToJson(_taskCycles, "Cycles");
            return cycle;
        }

        public void CreateNewEvent(string nameOfEvent, User student, DateTime startDate, DateTime sndDate, string description, Property property)
        {
            Event @event = new Event(nameOfEvent, student, startDate, sndDate, description, property);
            List<Event> events = GetEvents();
            events.Add(@event);
            TextFileUtilities.WriteToJson(events, "Events");
        }
       
    }
}
