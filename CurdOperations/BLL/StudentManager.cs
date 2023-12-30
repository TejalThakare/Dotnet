namespace BLL;
using BOL;
using DButils.DBmanager;

public static class StudentManager{
    public static List<Student> GetAllStudent(){
        List<Student> L1=new List<Student>();
        L1 = DBManager.GetAllStudent();
        return L1;
    }
}