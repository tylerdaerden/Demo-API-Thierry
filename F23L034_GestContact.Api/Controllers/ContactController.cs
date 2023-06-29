using F23L034_GestContact.Api.Models.Commands;
using F23L034_GestContact.Api.Models.Entities;
using F23L034_GestContact.Api.Models.Forms;
using F23L034_GestContact.Api.Models.Queries;
using F23L034_GestContact.Api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Tools.Cqs.Commands;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace F23L034_GestContact.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;
        private readonly ILogger _logger;

        public ContactController(IContactRepository contactRepository, ILogger<ContactController> logger)
        {
            _contactRepository = contactRepository;
            _logger = logger;
        }

        // GET: api/<ContactController>
        [HttpGet]
        public IActionResult Get()
        {
#warning Remplacer par l'id se trouvant dans le Token
            return Ok(_contactRepository.Execute(new GetContactsQuery(1)));
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
#warning Remplacer par l'id se trouvant dans le Token
            Contact? contact = _contactRepository.Execute(new GetContactQuery(id, 1));

            if (contact is null)
                return NotFound();

            return Ok(contact);
        }

        // POST api/<ContactController>
        [HttpPost]
        public IActionResult Post([FromBody] AddContactForm form)
        {
#warning Remplacer par l'id se trouvant dans le Token
            ICommandResult result = _contactRepository.Execute(new AddContactCommand(form.Nom, form.Prenom, form.Email, form.Anniversaire, form.Tel, 1));

            if(result.IsFailure)
            {
                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateContactForm form)
        {
#warning Remplacer par l'id se trouvant dans le Token
            ICommandResult result = _contactRepository.Execute(new UpdateContactCommand(id, form.Nom, form.Prenom, form.Email, form.Anniversaire, form.Tel, 1));

            if (result.IsFailure)
            {
                if (result.Message == "Not Found")
                    return NotFound();

                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }

        [HttpPatch("UpdatePhone/{id}")]
        public IActionResult Put(int id, [FromBody] UpdateContactPhoneForm form)
        {
#warning Remplacer par l'id se trouvant dans le Token
            ICommandResult result = _contactRepository.Execute(new UpdateContactPhoneCommand(id, form.Tel, 1));

            if (result.IsFailure)
            {
                if (result.Message == "Not Found")
                    return NotFound();

                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }

        //DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
#warning Remplacer par l'id se trouvant dans le Token
            ICommandResult result = _contactRepository.Execute(new DeleteContactCommand(id, 1));

            if (result.IsFailure)
            {
                if (result.Message == "Not Found")
                    return NotFound();

                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }
    }
}
