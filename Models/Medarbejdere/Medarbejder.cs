namespace MedarbejderVagtKaos.Models.Medarbejdere
{
    public class Medarbejder
    {
        static int nextId = 1;
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public int Tlf { get; set; }

        public Medarbejder()
        {
        }
        public Medarbejder(string name, string email, int tlf)
        {
            Id = nextId++;
            Name = name;
            Email = email;
            Tlf = tlf;
        }

		public override string ToString()
		{
			return $"{Name}, {Email}, {Tlf}";
		}
	}
}
