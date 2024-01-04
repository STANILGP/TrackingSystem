using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Storage
{
    public class Storage 
    {
        private Employee MYProfile;
        private List<Employee> MyEmployeeList;
        private List<Task> MyTaskList;
        private List<WorkCard> MyWorkCardList;

        public Employee GetMyProfile()
        { 
            return MYProfile;
        }
        public void SetMyProfile(Employee myProfile)
        {
            MYProfile = myProfile;
        }

        public List<Employee> GetMyEmployeeList() 
        {
            return MyEmployeeList;
        }

        public List <Task> GetMyTaskList() 
        {
            return MyTaskList;
        }
        public List<WorkCard>GetWorkCards() 
        {
            return MyWorkCardList;
        }
    }
}
