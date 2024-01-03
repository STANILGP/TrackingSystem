using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem
{
    public class Task
    {
        private DateTime startTask;
        private DateTime endTask;
        private string nameTask;
        private string descriptionTask;
        public Task(DateTime StartTask, DateTime EndTask,string NameTask,string DescrptionTask) 
        {
            this.startTask = StartTask;
            this.endTask = EndTask;
            this.nameTask = NameTask;
            this.descriptionTask=DescrptionTask;
        }
    }
}
