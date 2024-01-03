namespace BLL;
using BOL;
using DAL;

public class studentService{


    public static List<student> getAllData(){
        List<student> getdata = new List<student>();
        getdata = studentManager.getAllData();
        return getdata;
    }
     
    public static void InsertData(int ID,string NameFirst,string NameLast,string Dob,string EmailId){

    studentManager.InsertData(ID,NameFirst,NameLast,Dob,EmailId);

}
    
public static void updatestudent(int ID,string NameFirst,string NameLast,string Dob,string EmailId){

    studentManager.updatestudent(ID,NameFirst,NameLast,Dob,EmailId);


}

public static void deletestudent(int ID){

    studentManager.deletestudent(ID);


}





}