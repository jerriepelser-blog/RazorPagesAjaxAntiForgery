using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesAjaxAntiForgery.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public UserInformation Data { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Data = new UserInformation
            {
                FirstName = "Jerrie"
            };
        }

        public void OnPostRawFormData()
        {
            /*
            Create a user in your database, e.g.
            
            var user = new User
            {
                FirstName = Data.FirstName,
                LastName = Data.LastName
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            */
        }

        public void OnPostIndividualFields(UserInformation info)
        {
            /*
            Create a user in your database, e.g.
            
            var user = new User
            {
                FirstName = info.FirstName,
                LastName = info.LastName
            };
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            */
        }
    }
}