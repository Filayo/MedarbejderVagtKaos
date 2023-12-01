using MedarbejderVagtKaos.Models.Medarbejdere;

namespace MedarbejderVagtKaos.MockData
{
	public class MockMedarbejder
	{
		private static List<Medarbejder> _medarbejderListe = new List<Medarbejder>()
		{
			
			new Medarbejder("Jan Ole", "janole@example.dk", 11223344),
			new Medarbejder("Laurits Hansen", "laurits@example.dk", 44551199),
			new Medarbejder("Thea Laura", "thea@example.dk", 88776655),
			new Medarbejder("Sofus Jensen", "sofus@example.dk", 98765432),
			new Medarbejder("Erik Andersen", "erik@example.dk", 45678901),
			new Medarbejder("Sofie Nielsen", "sofie@example.dk", 11112222),
			new Medarbejder("Chris Hansen", "chris@example.dk", 99998888)

		};

		public static List<Medarbejder> GetMockMedarbejder()
		{
			return _medarbejderListe;
		}
	}
}
