namespace Task_1;

public class Contact //создание класса Contacts
{
    //Определение параметров класса
    /// <summary>
    /// фамилия
    /// </summary>
    private string surname;
    /// <summary>
    /// имя
    /// </summary>
    private string name;
    /// <summary>
    /// отчество
    /// </summary>
    private string secondName;
    /// <summary>
    /// мобильный номер телефона
    /// </summary>
    private string phone_number;
    /// <summary>
    /// домашний номер телефона
    /// </summary>
    private string home_phone_number;
    /// <summary>
    /// рабочий номер телефона
    /// </summary>
    private string work_phone_number;

    //Создание конструктора класса, с возможностью задать параметры 
    /// <summary>
    /// 
    /// </summary>
    /// <param name="surname">Фамилия контакта</param>
    /// <param name="name">Имя контакта</param>
    /// <param name="secondName">Отчество контакта</param>
    /// <param name="phoneNumber">Номер телефона</param>
    /// <param name="homePhoneNumber">Домашний номер телефона</param>
    /// <param name="workPhoneNumber">Рабочий номер телефона</param>
    public Contact(string surname, string name, string secondName, string phoneNumber, string homePhoneNumber, string workPhoneNumber)
    {
        this.surname = surname;
        this.name = name;
        this.secondName = secondName;
        this.phone_number = phoneNumber;
        this.home_phone_number = homePhoneNumber;
        this.work_phone_number = workPhoneNumber;
    }

    //Создание конструктора класса, с задачей параметров по умолчанию
    /// <summary>
    /// 
    /// </summary>
    /// <param name="surname">Фамилия контакта</param>
    /// <param name="name">Имя контакта</param>
    /// <param name="secondName">Отчество контакта</param>
    /// <param name="phoneNumber">Номер телефона</param>
    /// <param name="homePhoneNumber">Домашний номер телефона</param>
    /// <param name="workPhoneNumber">Рабочий номер телефона</param>
    public Contact()
    {
        surname = "Белавин";
        name = "Даниил";
        secondName = "Михайлович";
        phone_number = "79113186471";
        home_phone_number = "547568";
        work_phone_number = "79113186472";
    }
    
    //Метод для вывода всей информации на экран
    /// <summary>
    /// Метод для вывода информации о контакте
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return string.Format("Фамилия - {0} Имя - {1} Отчество - {2}. Номер телефона - {3}, рабочий номер телефона - {4}", surname, name, secondName, phone_number, work_phone_number);
    }
}