using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Storage
{
    public interface IStorage
    {
        public Employee GetMyProfile();
        public void SetMyProfile(Employee myProfile);
        public List<Employee> GetMyEmployeeList();
        public List<Task> GetMyTaskList();
        public List<WorkCard> GetWorkCards();
    }
}
