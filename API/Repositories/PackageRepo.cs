namespace API.Repositories;

using Models;

public class PackageService
{

    private List<Package> packages = new List<Package>();

    public Package CreatePackage(Package p)
    {
        packages.Add(p);
        return p;
    }

    public Package AddItemToPackage(string packageId, string itemId)
    {
        var package = packages.FirstOrDefault(p => p.Id == packageId);
        if (package == null)
        {
            throw new Exception("Package not found");
        }

        package.Cart.Add(new Item { Sku = itemId, Price = 1, Discount = 0 });
        return package;
    }

    public Package RemoveItemFromPackage(string packageId, string itemId)
    {
        var package = packages.FirstOrDefault(p => p.Id == packageId);
        if (package == null)
        {
            throw new Exception("Package not found");
        }
        package.Cart.RemoveAll(i => i.Sku == itemId);
        return package;
    }

    public Package AddCustomerToPackage(string packageId, Customer customer)
    {
        var package = packages.FirstOrDefault(p => p.Id == packageId);
        if (package == null)
        {
            throw new Exception("Package not found");
        }
        package.Customer = customer;
        return package;
    }

}