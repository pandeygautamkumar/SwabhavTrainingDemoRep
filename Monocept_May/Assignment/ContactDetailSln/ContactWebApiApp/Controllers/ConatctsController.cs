
using ContactDALLib.Model;
using ContactDALLib.Repository;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ContactWebApiApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("Contacts")]
    public class ConatctsController : ApiController
    {
        private ContactRepository _repository;
        public ConatctsController()
        {
            _repository = new ContactRepository();
        }
        [HttpGet]
        [Route("GetAllContacts")]
        public IHttpActionResult GetAllContacts()
        {
            List<Contact> contacts = new List<Contact>();
            contacts = _repository.GetContact();
            return Ok(contacts);
        }
        [HttpPost]
        [Route("AddContact")]
        public IHttpActionResult AddContact(Contact contact)
        {
            if (contact == null)
            {
                return BadRequest();
            }
            _repository.AddContact(contact);
            return Ok(new { Message = "Contact Added Successfullly!!" });
        }
        [HttpGet]
        [Route("GetContactById/{id:int}")]
        public IHttpActionResult GetContactById(int id)
        {
            Contact contact = _repository.GetContactById(id);
            if(contact == null)
            {
                return BadRequest();
            }
            return Ok(contact); 
        }
        [HttpDelete]
        [Route("DeleteContact/{id:int}")]
        public IHttpActionResult DeleteContact(int id)
        {
            Contact contact= _repository.GetContactById(id);    
            if( contact == null)
            {
                return BadRequest();
            }
            _repository.Delete(id);
            return Ok(new { Message = "Contact Deleted Successfullly!!" });
        }
        [HttpPut]
        [Route("UpdateContact/{id:int}")]
        public IHttpActionResult UpdateContact(int id,Contact contact)
        {
            Contact _contact=_repository.GetContactById(id);
            if (_contact == null)
            {
                return BadRequest();
            }
            _repository.UpdateContact(id, contact);
            return Ok(new { Message = "Contact Updated Successfully!!" });
        }
    }
}
