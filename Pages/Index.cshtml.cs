using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new(); //new(); inicializa o List<Category>

        public async Task OnGet()
        {
            //await Task.Delay(5000);

            for(var i = 0; i <= 100; i++)
            {
                Categories.Add(
                    item:new Category(i,
                        Title:$"Categoria {i}", 
                        Price:i*18.95M)); //Letra M entende que o valor é decimal, sem ele entenderá como um doble
            }
        }

        public void OnPost()
        {
        }

        public record Category(
            int Id,
            string Title,
            decimal Price);
    }
}
