using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quiz8.Models;
using Quiz8.Ripository;

namespace Quiz8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IUserRipository _userRipository;

        public IndexModel(ILogger<IndexModel> logger , IUserRipository userRipository)
        {
            _logger = logger;
            _userRipository = userRipository;
        }
        public List<User> users {  get; set; }

        public void OnGet()
        {
            users = _userRipository.GetAllUsers();
        }
    }
}