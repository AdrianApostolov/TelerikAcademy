using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Please, enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Please, enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Please, enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Please, enter company fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter company web site:");
        string webSite = Console.ReadLine();
        Console.Write("Please, enter manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Please, enter manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Please, enter manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Please, enter manager phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.Clear();

        Console.Write("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\n",
            companyName, companyAddress, phoneNumber, faxNumber, webSite);
        Console.WriteLine("Manager: {0} {1} (age.: {2}, tel. {3})",
            managerFirstName, managerLastName, managerAge, managerPhoneNumber);

    }
}

