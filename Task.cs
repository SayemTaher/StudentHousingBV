using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing
{
    public class Task
    {
        private User student;
        private DateTime dueDate;
        private Enumeration.TaskType type;

        public Task(User student, DateTime dueDate, Enumeration.TaskType type)
        {
            this.student = student;
            this.dueDate = dueDate;
            this.type = type;
        }

        public void SetStudent(User student)
        {
            this.student = student;
        }

        public User GetStudent()
        {
            return student;
        }

        public void SetDueDate(DateTime dueDate)
        {
            this.dueDate = dueDate;
        }

        public DateTime GetDueDate()
        {
            return this.dueDate;
        }

        public void SetTaskType(Enumeration.TaskType type)
        {
            this.type = type;
        }

        public Enumeration.TaskType GetTaskType()
        {
            return type;
        }

        public override string ToString()
        {
            return $"{type.ToString()} - {student.Name} - {dueDate.ToString()}";
        }
    }
}
