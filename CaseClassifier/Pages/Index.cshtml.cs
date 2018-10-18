using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model;


namespace CaseClassifier.Pages.Index

{
    public class CategoryPrediction
    {
        public string SentimentText { get; set; }
        public string Result { get; set; }
    }
  
   


    public class IndexModel : PageModel
    {
        [BindProperty]
        public CategoryPrediction CategoryPrediction { get; set; }
       
       public IActionResult OnGet()
        {
              
            
            return Page();

        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                CategoryPrediction.Result =PredictAsync(CategoryPrediction.SentimentText) ;

            }
            return Page();
        }
      



    }
    
}
