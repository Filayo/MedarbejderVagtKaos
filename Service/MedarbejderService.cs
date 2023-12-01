using MedarbejderVagtKaos.MockData;
using MedarbejderVagtKaos.Models.Medarbejdere;

namespace MedarbejderVagtKaos.Service
{
	public class MedarbejderService : IMedarbejderService
	{
		public List<Medarbejder> GetMedarbejdere()
		{
			// Use your data source (e.g., MockMedarbejder) to fetch Medarbejdere
			return MockMedarbejder.GetMockMedarbejder();
		}
	}
}
