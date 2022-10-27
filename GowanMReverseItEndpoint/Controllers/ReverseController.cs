/*Madeline Gowan
10-27-2022
Reverse It - Endpoint
In this program we must reverse user input

Peer review:Jovann Contreras: Code looks good I did it a similar way I am able to inpt a string and a number and they get reversed. There are no problems and everything looks good and runs good.
*/

using Microsoft.AspNetCore.Mvc;

namespace GowanMReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseController : ControllerBase
{
    [HttpGet]
    [Route("String/{userInput}")]
    //cheat sheet: https://localhost:xxxx/Reverse/String/x
    public string String(string userInput){
     string reverse = "";
        for (int i = userInput.Length - 1; i >= 0; i--)
        {
            reverse = reverse + userInput[i];
        }
        return "The reverse of " + userInput + " is " + reverse;
    }
    }
