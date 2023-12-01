using MedarbejderVagtKaos.Models.Medarbejdere;
using MedarbejderVagtKaos.Models.Vagtplan;

namespace MedarbejderVagtKaos.Pages.Vagtplan
{
    public class VagtViewModel
    {
        public Vagt Vagt { get; set; }
        public List<Medarbejder> Medarbejdere { get; set; }

    }
}
