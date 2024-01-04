using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Entity
{
    public enum Status
    {
        New,
        Stared,
        Ended,
        Canceled
    }
    public class Task
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startTask { get; set; }
        public DateTime endTask { get; set; }
        public Employee owner { get; set; }
        public Employee employee { get; set; }
        public float hourForTask {  get; set; }
        public float nowHour { get; set; }
        public Status status { get; set; }
        public Task(int ID,string Name,string Description,DateTime StartTask,DateTime EndTask,Employee Owner,Employee Employee,float HourForTask,float NowHour,Status Status)
        { 
            this.Id=ID;
            this.name = Name;
            this.description = Description;
            this.startTask = StartTask;
            this.endTask =EndTask;
            this.owner = Owner;
            this.employee = Employee;
            this.hourForTask = HourForTask;
            this.nowHour = NowHour;
            this.status = Status;
        }
    }
}
