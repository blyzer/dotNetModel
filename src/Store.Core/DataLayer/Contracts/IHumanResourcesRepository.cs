using System;
using System.Linq;
using System.Threading.Tasks;
using Store.Core.EntityLayer.HumanResources;

namespace Store.Core.DataLayer.Contracts
{
    public interface IHumanResourcesRepository : IRepository
    {
        IQueryable<Employee> GetEmployees(Int32 pageSize, Int32 pageNumber);

        Task<Employee> GetEmployeeAsync(Employee entity);

        Task<Int32> AddEmployeeAsync(Employee entity);

        Task<Int32> UpdateEmployeeAsync(Employee changes);

        Task<Int32> DeleteEmployeeAsync(Employee entity);
    }
}
