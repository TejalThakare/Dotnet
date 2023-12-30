namespace Notification;

public  class Notification1{

    public static void SendEmail(string name,string content){

        Console.WriteLine("email is send to" +name);

    }

    public static void SendSms(string name,string content){

         Console.WriteLine("SMS is send to" +name);
    }
}