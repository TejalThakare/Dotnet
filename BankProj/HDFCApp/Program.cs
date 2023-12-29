using banking;
using Notification;
using Taxation;

Account a1=new Account();
a1.balance=5000;
a1.Deposit(1000);
a1.Withdraw(500);
Console.WriteLine(a1.balance);

Notification1.SendEmail("raj","thakur");

Taxation1.Incometax(500);

NotificationOperation proxyEmailSender=new NotificationOperation(Notification1.SendEmail);
NotificationOperation proxySmsSender=new NotificationOperation(Notification1.SendSms);

NotificationOperation proxy=null;

proxy+=proxyEmailSender;
proxy+=proxySmsSender;

proxy(1234);



