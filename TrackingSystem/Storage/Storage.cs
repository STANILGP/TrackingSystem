using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Storage
{
    public class Storagee 
    {
        public Employee MYProfile;
        public List<Employee> MyEmployeeList;
        public List<Task> MyTaskList;
        public List<WorkCard> MyWorkCardList;

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
