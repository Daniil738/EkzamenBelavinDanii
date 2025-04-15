using Task_1;

public class Program
{
    static void Main(String[] args)
    {
        //объект класса дез задачи значений
        Task_1.Contact contact1 = new Task_1.Contact();
        Console.WriteLine(contact1.ToString());

        //объект класса с задачей значений параметрам
        Task_1.Contact contact2 =
            new Task_1.Contact("Степанов", "Степан", "Степанович", "79113148857", "589674", "73136488855");
        Console.WriteLine(contact2.ToString());
        
        Task_1.Contact contact3 = new Task_1.Contact();
        contact3.Surname = "Мутовкин";
        contact3.Name = "Егор";
        contact3.SecondName = "Александрович";
        contact3.PhoneNumber = "79113148857";
        contact3.HomePhoneNumber = "589674";
        contact3.WorkPhoneNumber = "589674";
        Console.WriteLine(contact3.ToString());
        
    }
}