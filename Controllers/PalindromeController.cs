using Microsoft.AspNetCore.Mvc;


namespace PalindromeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromeController : ControllerBase
    {
        private readonly PalindromeService _service;

        public PalindromeController(PalindromeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetPalindrome(string input)
        {
            string reversed = _service.ReverseString(input);
            bool isPalindrome = _service.IsPalindrome(input);

            PalindromeResponse response = new PalindromeResponse
            {
                ReversedString = reversed,
                IsPalindrome = isPalindrome
            };

            return Ok(response);
        }
    }

    internal class PalindromeResponse
    {
        public bool IsPalindrome { get; internal set; }
        public required string ReversedString { get; internal set; }
    }
}