namespace Task2;
public class ProductRepository
{
    public void AddProduct(Product product)
    {
        Database.Products.Add(product);
    }

    public void UpdateProduct(Product product)
    {
        var productToUpdate = Database.Products.SingleOrDefault(x=>x.Id == product.Id);
        if (productToUpdate != null)
        {
            productToUpdate.ProductType = product.ProductType;
            productToUpdate.Name = product.Name;    
            productToUpdate.Description = product.Description;
        }
    }

    public Product GetProductById(int id)
    {
        return Database.Products.SingleOrDefault(x => x.Id == id);
    }
}
