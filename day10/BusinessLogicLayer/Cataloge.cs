namespace BusinessLogicLayer;
using BusinessObjectLayer;
using DataAccessObject.Connected;
public class Cataloge{

public  List<Product>  GetAllProduct(){
    List<Product> allProducts =new List<Product>();
     allProducts=DBmanager.GetAllProduct();
    return allProducts;

}
}