using GraphQL_ProjectCode.Interface;
using GraphQL_ProjectCode.Model;
namespace GraphQL_ProjectCode.GQL_Types;

public class ProductMutationType{
private readonly IProductService _productService;
    public ProductMutationType(IProductService productService)
    {
        _productService = productService;
    }
    public Product Add(Product product){
        _productService.Add(product);
        return product;
    }

    public Product Update(int id, Product product){
        _productService.Update(id, product);
        return product;
    }

    public void Remove(int id){
        _productService.Delete(id);
    }
}
