namespace Hardware;

public class IPrinter:Printer,Scanner{
    public void print(){
        Console.WriteLine("printer is started.........");
    }
    public void Scan(){
        Console.WriteLine("scanner is started");
    }

}