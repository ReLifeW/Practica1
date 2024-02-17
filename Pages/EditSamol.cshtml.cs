using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practica1.modal;
using Practica1.Repozidori;

namespace Practica1.Pages
{
    public class EditSamol : PageModel
    {
        public EditSamol(ISamolet userRepository)
        {
            _samRepository = userRepository;
        }

        private ISamolet _samRepository;
        public Samolet? Samolet { get; set; }

        public string? Type { get; set; }
        public string? Name { get; set; }

        public IActionResult OnGet(int id)
        {
            Samolet = _samRepository.Get(id);
            Samolet ??= new();
            return Page();
        }

        public IActionResult OnPost(Samolet? userForm)
        {

            var samDB = _samRepository.Update(userForm);
            if (samDB == null) return NotFound();
            return Page();
        }
    }
}
