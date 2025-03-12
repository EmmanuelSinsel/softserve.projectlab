using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PackagesController : ControllerBase
{
    private readonly PackageService _packageService;

    public PackagesController(PackageService packageService)
    {
        _packageService = packageService;
    }

    [HttpPost]
    public async Task<ActionResult<Package>> CreatePackage([FromBody] Package package)
    {
        var result = _packageService.CreatePackage(package);
        return Ok(result);
    }

    [HttpPost("{packageId}/Items/{itemId}")]
    public async Task<ActionResult<Package>> AddItem([FromRoute] string packageId, [FromRoute] string itemId)
    {
        var result = _packageService.AddItemToPackage(packageId, itemId);
        return Ok(result);
    }

    [HttpDelete("{packageId}/Items")]
    public async Task<ActionResult<Package>> DeleteItem([FromRoute] string packageId, [FromRoute] string itemId)
    {
        var result = _packageService.RemoveItemFromPackage(packageId, itemId);
        return Ok(result);
    }

    [HttpPost("{packageId}/Customers")]
    public async Task<ActionResult<Package>> AddCustomer([FromRoute] string packageId, [FromBody] Customer customer)
    {
        var result = _packageService.AddCustomerToPackage(packageId, customer);
        return Ok(result);
    }
}