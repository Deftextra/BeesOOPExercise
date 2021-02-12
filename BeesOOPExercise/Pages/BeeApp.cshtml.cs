using System;
using System.Threading.Tasks;
using BeesOOPExercise.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BeesOOPExercise.Pages
{
    public class BeeAppModel : PageModel
    {
        public BeeAppModel(BeesData beesData)
        {
            BeesData = beesData;
        }

        public BeesData BeesData { get; }
        
        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
        
        public IActionResult OnGetDamage()
        {
            BeesData.DamageAll();
            
            return Page();
        }
        
    }
}