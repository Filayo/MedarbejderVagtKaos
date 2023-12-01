using MedarbejderVagtKaos.Models.Medarbejdere;
using MedarbejderVagtKaos.Models.Vagtplan;
using MedarbejderVagtKaos.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MedarbejderVagtKaos.Pages.Vagtplan
{
		public class CreateVagtModel : PageModel
		{
			#region Properties

			private readonly IVagtService _vagtService;
			private readonly IMedarbejderService _medarbejderService;
			public List<Medarbejder> Medarbejdere { get; set; }

			[BindProperty]
			public Vagt VagtMedarbejder { get; set; }
			#endregion

			#region Constructor
			public CreateVagtModel(IVagtService vagtService, IMedarbejderService medarbejderService)
			{
				_vagtService = vagtService;
				_medarbejderService = medarbejderService;
			}

			#endregion

			#region Methods
			public SelectList GetMockMedarbejder()
			{
				return new SelectList(Models.Vagtplan.Vagt.MedarbejderOptions());
			}

			public SelectList StartTidOptions()
			{
				return new SelectList(Models.Vagtplan.Vagt.StartTidOptions());
			}

			public SelectList SlutTidOptions()
			{
				return new SelectList(Models.Vagtplan.Vagt.SlutTidOptions());
			}

			public void OnGet()
			{
				//VagtMedarbejder = new VagtViewModel
				//{
				//	Medarbejdere = _medarbejderService.GetMedarbejdere(),
				//	Vagt = new Vagt(),


				//};
			}

			public IActionResult OnPost()
			{
				if (!ModelState.IsValid)
				{
					return Page();
				}

				//_vagtService.AddVagt(VagtMedarbejder.Vagt);

				return RedirectToPage("GetAllVagter");
			}

			#endregion
		}
	}



//_vagtService.AddVagt(Vagt);
//Console.WriteLine("1");
//if (!ModelState.IsValid)
//{
//    Console.WriteLine("2");
//    return Page();
//    Console.WriteLine("3");
//}
//_vagtService.AddVagt(Vagt);

//return RedirectToPage("GetAllVagter");