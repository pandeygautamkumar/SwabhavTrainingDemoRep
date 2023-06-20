using GenericRepositoryPatternApp.EF;
using GenericRepositoryPatternApp.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepositoryPatternApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        IRepository<Organization> _organizatioRepo;
        public OrganizationController(IRepository<Organization> orgizatioRepo)
        {
            _organizatioRepo = orgizatioRepo;
        }
        [HttpGet]
        [Route("/GetAllOrganization")]
        public IActionResult GetAllOrganization()
        {
            var organizations = _organizatioRepo.Get().ToList();
            return Ok(organizations);
        }
        [HttpPost]
        [Route("/AddOrganization")]
        public IActionResult AddOrganization(Organization organization)
        {
            _organizatioRepo.Add(organization);
            return Ok();
        }
    }
}
