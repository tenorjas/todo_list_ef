using System;

namespace todo_list.Models
{
    public class TodoModel
    {
        public int ID {get; set;}
        public string TaskName {get; set;}
        public bool IsComplete {get;set;} = false;
        public DateTime Time {get; set;} = DateTime.Now;

        public void Complete()
        {
            IsComplete = true;
            Time = DateTime.Now;
        }
        
    }
}