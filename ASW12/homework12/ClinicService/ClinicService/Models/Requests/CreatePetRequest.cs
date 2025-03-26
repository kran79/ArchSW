namespace ClinicService.Models.Requests
{
    public class CreatePetRequest
    {
        public string AnimalType;

        public int ClientId { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
