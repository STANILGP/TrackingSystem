using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem
{
    public class WorkCard
    {
        private int ID;
        private DateTime startTask;
        private DateTime endTask;
        private string nameTask;
        private string descriptionTask;
        public WorkCard(int id,DateTime StartTask, DateTime EndTask,string NameTask,string DescrptionTask) 
        {
            this.ID = id;
            this.startTask = StartTask;
            this.endTask = EndTask;
            this.nameTask = NameTask;
            this.descriptionTask=DescrptionTask;
        }
    }
}
