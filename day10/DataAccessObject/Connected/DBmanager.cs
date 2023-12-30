namespace DataAccessObject.Connected;
using BusinessObjectLayer;
using MySql.Data.MySqlClient;

public class DBmanager{

 

    public static List<Product> GetAllProduct(){
        List<Product> list=new List<Product>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=@"server=192.168.10.150;port=3306;user=dac43;password=welcome;database=dac43";
        string query="select * from Product";
        MySqlCommand command=new MySqlCommand(query,conn);

        try{
            conn.Open();
            MySqlDataReader reader=command.ExecuteReader();

            while(reader.Read()){

            Product product=new Product();
            int id=int.Parse(reader["Id"].ToString());
            string name=reader["Name"].ToString();
            string description=reader["Description"].ToString();
            product.Id=id;
            product.Name=name;
            product.Description=description;
            list.Add(product);
            }
            reader.Close();
        }
        catch(Exception e){
            Console.WriteLine(e.Message);

        }
        finally{
            conn.Close();
        }
        return list;
}
}
