namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class studentManager {


    static string DBconn = @"server=192.168.10.150; port=3306; user=dac43; password=welcome; database=dac43";

    public static List<student> getAllData(){

        List<student> getstu = new List<student>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = DBconn;
        string data = "select * from student2";
        MySqlCommand Command = new MySqlCommand(data,connection);
        try{
            connection.Open();
            MySqlDataReader Reader = Command.ExecuteReader();
            while(Reader.Read()){
                int id=int.Parse(Reader["id"].ToString());
                string NameFirst=Reader["namefirst"].ToString();
                string NameLast=Reader["nameLast"].ToString();
                string Dob=Reader["Dob"].ToString();
                string EmailId=Reader["Emailid"].ToString();

                student s1=new student{
                        Id=id,
                        NameFirst=NameFirst,
                        NameLast=NameLast,
                        Dob=Dob,
                        EmailId=EmailId
            };
            getstu.Add (s1);
        }
        }
        catch(Exception ee){
            Console.WriteLine(ee.Message);
        }
        finally{
            connection.Close();
        }
        return getstu;   
    }

  public static void InsertData(int ID,string NameFirst,string NameLast,string Dob,string EmailId){

        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = DBconn;
        string insertd = "insert into student2 values(@ID,@NameFirst,@NameLast,@Dob,@EmailId)";
        MySqlCommand command = new MySqlCommand(insertd,connection);
        //DateTime myDate = DateTime.Parse(Dob);
        command.Parameters.AddWithValue(@"Id",ID);
        command.Parameters.AddWithValue(@"NameFirst",NameFirst);
        command.Parameters.AddWithValue(@"NameLast",NameLast);
        command.Parameters.AddWithValue(@"Dob",Dob);
        command.Parameters.AddWithValue(@"EmailId",EmailId);
        try{
            connection.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
    }

public static void updatestudent(int ID,string NameFirst,string NameLast,string Dob,string EmailId)
{
    MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = DBconn;
        string insertd = "update student2 set NameFirst='"+NameFirst+"',NameLast='"+NameLast+"',DOB='"+Dob+"',EmailId='"+EmailId+"' where id="+ID;
                // "update Login set Username='"+Username+"',Password='"+Password+"' where id="+id
        MySqlCommand command = new MySqlCommand(insertd,connection);
        //DateTime myDate = DateTime.Parse(Dob);
        command.Parameters.AddWithValue(@"Id",ID);
        command.Parameters.AddWithValue(@"NameFirst",NameFirst);
        command.Parameters.AddWithValue(@"NameLast",NameLast);
        command.Parameters.AddWithValue(@"DOB",Dob);
        command.Parameters.AddWithValue(@"EmailId",EmailId);
        try{
            connection.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }


}


public static void deletestudent(int ID){

        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString = DBconn;
        string insertd = "delete from student2 where id="+ID;
        MySqlCommand command = new MySqlCommand(insertd,connection);
        
        try{
            connection.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            connection.Close();
        }
    }







}