using ASPNET_Core_Diagnostics.Models;
using System.Collections.Generic;

namespace ASPNET_Core_Diagnostics.Services
{
    public interface IService<T> where T :class
    {
        IEnumerable<T> Get();
    }

    public class EmployeeService : IService<Employee>
    {
        DataAccess ds;
        public EmployeeService(DataAccess d)
        {
            ds = d;
        }
        public IEnumerable<Employee> Get()
        {
            return ds.Get();
        }
    }
}
