using EmployeeMicroservice.Controller;
using Microsoft.AspNetCore.Mvc;
using OfferMicroservice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeMicroservice.Models
{
    public interface IEmployeeRepository
    {
        ActionResult GetEmployeeList();
        Task<ActionResult> ViewEmployeeOffers(int id);
        Task<ActionResult> ViewMostLikedOffers(int id);
        Task<ActionResult> GetPointsList();
    }

}
