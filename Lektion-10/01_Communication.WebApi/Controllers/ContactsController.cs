using _01_Communication.Shared.Models;
using _01_Communication.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace _01_Communication.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IFileManager _fileManager;
        private readonly string _filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file.json";
        private List<ContactPerson> _contacts;

        public ContactsController(IFileManager fileManager)
        {
            _fileManager = fileManager;
            _contacts = new List<ContactPerson>();
        }

        [HttpPost]
        public IActionResult Save(ContactPerson contact)
        {
            _contacts.Add(contact);
            _fileManager.Save(_filePath, JsonConvert.SerializeObject(_contacts));

            return new OkResult();
        }

    }
}
