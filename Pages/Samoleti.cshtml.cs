using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1.modal;
using Practica1.Repozidori;

namespace Practica1.Pages
{
    public class SamoletiModel : PageModel
    {

        public SamoletiModel(ISamolet samoletiRepozitori)
        {
            _samoletiRepozitori = samoletiRepozitori;
        }
        private ISamolet _samoletiRepozitori;
        public List<Samolet> samoletus { get; set; }
        public IActionResult OnGet()
        {
            samoletus = _samoletiRepozitori.GetLL();
            return Page();
        }
    }
}
