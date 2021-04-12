using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDataView.Data;
using StudentDataView.Models;

namespace StudentDataView.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly StudentDataContext _context;

        public ContactsController(StudentDataContext context)
        {
            _context = context;
        }

        // GET: api/Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactView>>> GetContacts()
        {
            var contacts = await _context.Contacts.ToListAsync();
            return contacts.Select(contacts => new ContactView(contacts)).ToArray();
        }

        // GET: api/Contacts/5
        [HttpGet("{studentId}")]
        public async Task<ActionResult<IEnumerable<ContactView>>> GetContactDataModel(
            string studentId)
        {
            var contactsQueryable = from contact in _context.Contacts
                                    select contact;

            contactsQueryable = contactsQueryable.Where(contact =>
                contact.StudentDataModelID == studentId);

            var contacts = await contactsQueryable
                .AsNoTracking()
                .ToListAsync();

            var studentsView = contacts.Select(contact => 
                new ContactView(contact))
                .ToArray();

            return studentsView;
        }

        private bool ContactDataModelExists(string id)
        {
            return _context.Contacts.Any(e => e.StudentDataModelID == id);
        }
    }
}
