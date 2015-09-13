# Fluent Interface
### Creational Design Pattern

## Обобщение
Fluent Interface-ът цели да предостави по-четим и разбираем код. Намалява Syntactical noise-а и изразява по-ясно какво 
върши кода. Имплементира се чрез method cascading или по-конкретно с method chaining.

## Конкретна имплементация
Създаване на клиент:

###### Defines the data context
~~~c#
public class CustomerContext
{
    public string FirstNameirstName { get; set; }
    public string LastName {get; set;}
	public string Gender { get; set; }
	public string Address { get; set; }
}
~~~

###### Defines the customer class
~~~c#
public class Custemer
{
    Context context = new Context();

        
	public Customer FirstName(string firstName)
	{
		context.FirstName = firstName;
		return this;
	}

	public Customer LastName(string lastName)
	{
		context.LastName = lastName;
		return this;
	}

	public Customer Gender(string gender)
	{
		context.Gender = gender;
		return this;
	}

	public Customer Address(string address)
	{
		context.Address = address;
		return this;
	}
	
	public void Print()
	{
		Console.WriteLine("First name: {0} \nLast name: {1} \nGender: {2} \nAddress: {3}"
		,context.FirstName,context.LastName,context.Gender,context.Address);
	}
}
~~~

###### Usage
~~~c#
public static void Main()
{
    var custemer = new Custemer();
	
	//using the method chaining to assign and print data with a single line
	custemer
		.FirstName("Pesho")
		.LastName("Goshov")
		.Gender("male")
		.Address("Kaspichan")
		.Print();
}
~~~
