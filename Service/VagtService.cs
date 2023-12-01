using MedarbejderVagtKaos.MockData;
using MedarbejderVagtKaos.Models.Vagtplan;

namespace MedarbejderVagtKaos.Service
{
	public class VagtService : IVagtService
	{
		private List<Vagt> _vagter;
		public VagtService()
		{
	
			_vagter = MockVagter.GetMockVagter();
			//_vagter = JsonFileVagtService.GetJsonVagter().ToList();
		}
		public void AddVagt(Vagt vagt)
		{
			_vagter.Add(vagt);
			//JsonFileVagtService.SaveJsonVagter(_vagter);
		}

		public Vagt GetVagt(int id)
		{
			foreach (Vagt vagt in _vagter)
			{
				if (vagt.Id == id)
					return vagt;
			}

			return null;
		}


		public List<Vagt> GetVagter() { return _vagter; }

		}
	}
