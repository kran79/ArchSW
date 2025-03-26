using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ClinicTest
{
    public class Tests
    {
        private ClientController clientController;
        private PetController petController;
        private ConsultationController consultationController;

        private Mock<IClientRepository> mockClientRepo;
        private Mock<IPetRepository> mockPetRepo;
        private Mock<IConsultationRepository> mockConsultationRepo;

        [SetUp]
        public void Setup()
        {
            mockClientRepo = new Mock<IClientRepository>();
            mockPetRepo = new Mock<IPetRepository>();
            mockConsultationRepo = new Mock<IConsultationRepository>();

            clientController = new ClientController(mockClientRepo.Object);
            petController = new PetController(mockPetRepo.Object);
            consultationController = new ConsultationController(mockConsultationRepo.Object);
        }

        [Test]
        public void Test1_getAllClients()
        {
            var clients = new List<Client> { new Client(), new Client(), new Client() };
            mockClientRepo.Setup(repo => repo.GetAll()).Returns(clients);

            var result = clientController.GetAll().Result as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<Client>>(result.Value);
            Assert.AreEqual(3, ((List<Client>)result.Value).Count);
        }

        [Test]
        public void Test2_getAllPets()
        {
            var pets = new List<Pet> { new Pet(), new Pet() };
            mockPetRepo.Setup(repo => repo.GetAll()).Returns(pets);

            var result = petController.GetAll().Result as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<Pet>>(result.Value);
            Assert.AreEqual(2, ((List<Pet>)result.Value).Count);
        }

        [Test]
        public void Test3_getAllConsultations()
        {
            var consultations = new List<Consultation> { new Consultation(), new Consultation(), new Consultation(), new Consultation() };
            mockConsultationRepo.Setup(repo => repo.GetAll()).Returns(consultations);

            var result = consultationController.GetAll().Result as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<List<Consultation>>(result.Value);
            Assert.AreEqual(4, ((List<Consultation>)result.Value).Count);
        }

        [Test]
        public void Test4_createClient()
        {
            var request = new CreateClientRequest
            {
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Document = "123 4567",
                Birthday = new DateTime(1990, 1, 1)
            };

            mockClientRepo.Setup(repo => repo.Create(It.IsAny<Client>())).Returns(1);

            var result = clientController.Create(request).Result as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<int>(result.Value);
            Assert.AreEqual(1, (int)result.Value);

            mockClientRepo.Verify(r => r.Create(It.IsAny<Client>()), Times.Once);
        }

        [Test]
        public void Test5_createPet()
        {
            var request = new CreatePetRequest
            {
                Name = "Барсик",
                ClientId = 1,
                AnimalType = "Кот",
                Birthday = new DateTime(2020, 5, 10)
            };

            mockPetRepo.Setup(repo => repo.Create(It.IsAny<Pet>())).Returns(2);

            var result = petController.Create(request).Result as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<int>(result.Value);
            Assert.AreEqual(2, (int)result.Value);

            mockPetRepo.Verify(r => r.Create(It.IsAny<Pet>()), Times.Once);
        }

        [Test]
        public void Test6_createConsultation()
        {
            var request = new CreateConsultationRequest
            {
                PetId = 1,
                ClientId = 1,
                Description = "Общий осмотр",
                ConsultationDate = DateTime.Now
            };

            mockConsultationRepo.Setup(repo => repo.Create(It.IsAny<Consultation>())).Returns(3);

            var result = consultationController.Create(request).Result as OkObjectResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<int>(result.Value);
            Assert.AreEqual(3, (int)result.Value);

            mockConsultationRepo.Verify(r => r.Create(It.IsAny<Consultation>()), Times.Once);
        }
    }
}
