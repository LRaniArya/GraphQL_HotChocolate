using GraphQL_ProjectCode.Model;

namespace GraphQL_ProjectCode.Interface
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Add(Product product);
        Product Update(int id, Product product);
        void Delete(int id);

    }
}
