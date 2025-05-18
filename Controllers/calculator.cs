using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CalculatorController : ControllerBase
{
    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Add(decimal x, decimal y)
    {
        return x+y;
    }
    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Subtract(decimal x, decimal y)
    {
        return x-y;
    }
    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Multiply(decimal x, decimal y)
    {
        return x*y;
    } 
    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Divide(decimal x, decimal y)
    {
        return x/y;
    }
    [Route("{x}/{y}")]
    [HttpGet]
    public decimal Modulo(decimal x, decimal y)
    {
        return x%y;
    }        
}
