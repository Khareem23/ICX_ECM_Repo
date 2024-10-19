using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ICM_ECM.Web.Pages;

public class FileModel : PageModel
{
    private readonly ILogger<FileModel> _logger;

    public FileModel(ILogger<FileModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}