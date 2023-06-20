using GenericRepositoryPatternApp.EF;
using GenericRepositoryPatternApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPatternApp.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        IRepository<Organization> _organizationRepo;

        public OrganizationController(IRepository<Organization> organizationRepo)
        {
            _organizationRepo = organizationRepo;
        }
        [Route("/getall")]
        [HttpGet]
        public IActionResult GetAllOrganization()
        {
            var organization = _organizationRepo.Get().ToList();
            return Ok(organization);
        }
        [Route("/addOrganization")]
        [HttpPost]
        public IActionResult AddOrganization(Organization organization)
        {
            //data validation
            _organizationRepo.Add(organization);
            return Ok();
        }
    }
}
