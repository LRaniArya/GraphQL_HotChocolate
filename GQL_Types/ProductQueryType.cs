using GraphQL_ProjectCode.Model;
using GraphQL_ProjectCode.Interface;
namespace GraphQL_ProjectCode.GQL_Types;


public class ProductQueryType
{

    private readonly IProductService _productService;

    public ProductQueryType(IProductService productService)
    {
        _productService = productService;
    }
    public List<Product> AllProduct()
    {
        return _productService.GetAll();
    }

    public Product GetProduct(int id)
    {
        return _productService.GetById(id);
    }
} 