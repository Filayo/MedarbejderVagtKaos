using MedarbejderVagtKaos.Models.Medarbejdere;
using System.ComponentModel.DataAnnotations;

namespace MedarbejderVagtKaos.Models.Vagtplan
{
    public class Vagt
    {
        static int nextId = 1;
        public int Id { get; }
        public Medarbejder Medarbejder { get; set; }
        public string StartTid { get; set; }
        public string SlutTid { get; set; }

        public Vagt()
        {
            Id = nextId++;
        }

        public Vagt(Medarbejder medarbejder, string startTid, string slutTid)
        {
            Id = nextId++;
            Medarbejder = medarbejder;
            StartTid = startTid;
            SlutTid = slutTid;
        }
		public static IEnumerable<Medarbejder> MedarbejderOptions()
		{
			return new[]
			{
			new Medarbejder("Jan Ole", "janole@example.dk", 11223344),
			new Medarbejder("Laurits Hansen", "laurits@example.dk", 44551199),
			new Medarbejder("Thea Laura", "thea@example.dk", 88776655),
			new Medarbejder("Sofus Jensen", "sofus@example.dk", 98765432),
			new Medarbejder("Erik Andersen", "erik@example.dk", 45678901),
			new Medarbejder("Sofie Nielsen", "sofie@example.dk", 11112222),
			new Medarbejder("Chris Hansen", "chris@example.dk", 99998888)
			};
		}


		public static IEnumerable<string> StartTidOptions()
        {
            return new[]
            {
                "08:00", "09:00", "10:00", "11:00", "12:00",
                "13:00", "14:00", "15:00", "16:00", "17:00"
            };
        }

        public static IEnumerable<string> SlutTidOptions()
        {
            return new[]
            {
                "12:00", "13:00", "14:00", "15:00", "16:00",
                "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"
            };
        }
    }
}
