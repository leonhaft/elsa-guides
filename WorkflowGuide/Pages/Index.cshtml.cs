using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WorkflowGuide.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IPartNumberService _partNumberService;

        public List<Category> categories { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IPartNumberService partNumberService)
        {
            _logger = logger;
            this._partNumberService = partNumberService;
        }

        public async Task OnGetAsync()
        {
            categories = await _partNumberService.CategoriesAsync();
        }

        
    }
}