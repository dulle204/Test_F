using Task2;

ProductRepository productRepository = new();

ProductCategory category = new();
ProductType productType = new()
{
    ProductCategory = category,
    Id = 1,
    Name = "Test",
    Description = "Test",
};
ProductType productType2 = new()
{
    ProductCategory = category,
    Id = 1,
    Name = "Test 2",
    Description = "Test 2",
};
Product product = new()
{
    ProductType = productType,
    Description = "dsds",
    Name = "Test",
    Id = 1
};

productRepository.AddProduct(product);
var productToUpdate = productRepository.GetProductById(product.Id);
Console.WriteLine($"Added product type - {productToUpdate.ProductType.Name}");
productToUpdate.ProductType = productType2;
// This way we can update anything
// Change category or type and change position of product anywhere in the menu
// We can add additoinal sort column to handle order
productRepository.UpdateProduct(productToUpdate);
var updatedProuct = productRepository.GetProductById(product.Id);
Console.WriteLine($"Update product type - {updatedProuct.ProductType.Name}");
