using System;


public class Magazine
{
    string name;
    int year;
    string description;
    string phone;
    string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value > 0)
            {
                year = value;
            }
            else
            {
                Console.WriteLine("Ошибка, год не тот ");

            }
        }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    public string tEmail
    {
        get { return email; }
        set { email = value; }
    }

    public void SetData(string name, int yaer, string description, string phone, string email)
    {
        this.name = name;
        this.year = yaer;   
        this.description = description; 
        this.phone = phone;
        this.email = email;

    }
    public override string ToString()
    {
        return $"Название  {name}\n" +
               $"Год {year} \n" +
               $"Описание {description} \n" +
               $"Телефон {phone} \n" +
               $"Email {email} \n";

    }
}

public class Journal
{
    string name;
    string adress;
    string description;
    string phone;
    string email;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Adress
    {
        get { return adress; }
        set
        {
            adress = value;
        }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public void SetData(string name, string adress, string description, string phone, string email)
    {
        this.name = name;
        this.adress = adress;
        this.description = description;
        this.phone = phone;
        this.email = email;

    }
    public override string ToString()
    {
        return $"Название  {name}\n" +
               $"Адресс {adress} \n" +
               $"Описание {description} \n" +
               $"Телефон {phone} \n" +
               $"Email {email} \n";

    }
}



public class Website
{

    private string name;
    private string url;
    private string description;
    private string ipAddress;


    public Website()
    {
        name = string.Empty;
        url = string.Empty;
        description = string.Empty;
        ipAddress = string.Empty;
    }


    public Website(string name, string url, string description, string ipAddress)
    {
        this.name = name;
        this.url = url;
        this.description = description;
        this.ipAddress = ipAddress;
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Url
    {
        get { return url; }
        set { url = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string IpAddress
    {
        get { return ipAddress; }
        set { ipAddress = value; }
    }


    public void InputData()
    {
        Console.Write("Введите название сайта: ");
        name = Console.ReadLine();
        Console.Write("Введите путь: ");
        url = Console.ReadLine();
        Console.Write("Введите описание: ");
        description = Console.ReadLine();
        Console.Write("Введите IP-адрес: ");
        ipAddress = Console.ReadLine();
    }

    public string ToString()
    {
        return $"Название сайта: {name}\n" +
               $"URL: {url}\n" +
               $"Описание: {description}\n" +
               $"IP-адрес: {ipAddress}\n";
    }
}




class Program
{
    static void Main()
    {

        //Website myWebsite = new Website();
        //myWebsite.InputData();

        //Console.WriteLine(myWebsite.ToString());
        //myWebsite.Name = "Updated Website Name";
        //Console.WriteLine($"Обновленное название сайта: {myWebsite.Name}");

        Magazine magazine = new Magazine();
        magazine.SetData("Научный", 2000, "Чет на научном",
                        "098 354 28 32", "gmail");

        Console.WriteLine(magazine.ToString());

        Journal journal = new Journal();
        journal.SetData("Научный", "Проспект ...", "Чет на научном",
                        "098 354 28 32", "gmail");

        Console.WriteLine(journal.ToString());

    }
}


