namespace DButils.DBmanager;
using MySql.Data.MySqlClient;
using BOL;


public class DBManager{

    public static string constring="server=192.168.10.150;port=3306;user=dac43;password=welcome;database=dac43";

    public static List<Student> GetAllStudent(){
        List<Student> L1=new List<Student>();
        MySqlConnection conn=new MySqlConnection();
        conn.ConnectionString=constring;
        string getData="select * from student1";
        try{
            MySqlCommand Cmd=new MySqlCommand(getData, conn);
            Cmd.Connection=conn;
            conn.Open();
            Cmd.CommandText=getData;
            MySqlDataReader reader=Cmd.ExecuteReader();
            while(reader.Read()){
                int id=int.Parse(reader["id"].ToString());
                string name=reader["name"].ToString();
                string marks=reader["marks"].ToString();
                Student s1=new Student{
                    Id=id,
                    Name=name,
                    Marks=marks
                };
                L1.Add(s1);
            }

        }
        catch(Exception e){
            Console.WriteLine(e.Message);

        }
        finally{
            conn.Close();

        }
        return L1;

    }
}