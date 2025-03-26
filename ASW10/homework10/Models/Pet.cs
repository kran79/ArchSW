namespace ClinicService.Models
{
    public class Pet
    {
        public int PetId { get; set; }

        public int ClientId { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
    namespace ClinicService.Services
    {
        public interface IPetRepository : IRepository<Pet, int> { }
    }

    namespace ClinicService.Services
    {
        public interface IConsultationRepository : IRepository<Consultation, int> { }
    }

}
