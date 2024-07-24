using EcoTechMVC.Models;
using MongoDB.Driver;

namespace EcoTechMVC.Services
{

    public class MongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }

    public interface IContactFormService
    {
        Task SaveContactFormAsync(ContactForm contactForm);
    }

    public class ContactFormService : IContactFormService
    {
        private readonly IMongoCollection<ContactForm> _contactForms;

        public ContactFormService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetSection("MongoDB:ConnectionString").Value);
            var database = client.GetDatabase(configuration.GetSection("MongoDB:DatabaseName").Value);
            _contactForms = database.GetCollection<ContactForm>(configuration.GetSection("MongoDB:CollectionName").Value);
        }

        public async Task SaveContactFormAsync(ContactForm contactForm)
        {
            await _contactForms.InsertOneAsync(contactForm);
        }
    }

}
