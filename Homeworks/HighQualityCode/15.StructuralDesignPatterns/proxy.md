# Proxy Pattern

#### Мотивация
**Proxy Pattern** е **структурен (structural) дизайн патърн**, който се използва, когато е необходима възможност за
контролиране на достъпа до даден обект. Например, когато ни трябват само няколко метода от по-голям обект - вместо
да бъде инициализиран преди цялата му функционалност да е необходима, може да бъде използван по-малък, който експоузва
същия интерфейс и се нарича proxy.

#### Цел
* Да осигури заместител на обект, за да контролира референциите към него
 
#### Структура 
 ![alt text] (https://rawgit.com/AdrianApostolov/TelerikAcademy/master/Homeworks/HighQualityCode/15.StructuralDesignPatterns/imgs/proxy-uml.svg "Proxy UML Diagram")

#### Участниците в процеса:
- **Subject** - Интерфейс, имплементиран от Real Subject, представящ услугите му; имплементиран и от Proxy
- **Proxy** - съдържа референция, която му позволява да достъпма реалния обект; имплементира subject интерфейса, за да бъде заместител на реалния обект; контролира достъпа до обекта и може да бъде
отговорен за създаването и изтриването му
- **Real Subject** - реалният обект, който proxy представя

#### Предимства
* Предоставя сигурност
* Намалява възможността от дуплициране на обекти

#### Приложение
* Когато е необходимо да бъде контролиран достъпът до обекта

#### Пример
~~~c#
    interface IActualPrices
    {
        string GoldPrice
        {
            get;
        }
     
        string SilverPrice
        {
            get;
        }
     
        string DollarToRupee
        {
            get;
        }
    }
    
    class ActualPrices : IActualPrices
    {
        public string GoldPrice
        {
            get
            {
                // This value should come from a DB typically
                return "100";
            }
        }
     
        public string SilverPrice
        {
            get
            {
                // This value should come from a DB typically
                return "5";
            }
        }
     
        public string DollarToRupee
        {
            get
            {
                // This value should come from a DB typically
                return "50";
            }
        }
    }
    
    static void Main(string[] args)
    {
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        TcpListener listener = new TcpListener(ip, 9999);
     
        while (true)
        {
            listener.Start();
            Console.WriteLine("Waiting .....");
            Socket s = listener.AcceptSocket();
     
            byte[] b = new byte[100];
     
            int count = s.Receive(b);
     
            string input = string.Empty;
     
            for (int i = 0; i < count; i++)
            {
                input += Convert.ToChar(b[i]);
            }
     
            IActualPrices realSubject = new ActualPrices();
            string returnValue = string.Empty;
     
            switch (input)
            {
                case "g":
                    returnValue = realSubject.GoldPrice;
                    break;
                case "s":
                    returnValue = realSubject.SilverPrice;
                    break;
                case "d":
                    returnValue = realSubject.DollarToRupee;
                    break;
            }
     
            ASCIIEncoding asen = new ASCIIEncoding();
            s.Send(asen.GetBytes(returnValue));
     
            s.Close();
            listener.Stop();
            Console.WriteLine("Response Sent .....");
        }
    }
    
    class ActualPricesProxy : IActualPrices
    {
        public string GoldPrice
        {
            get
            {
                return GetResponseFromServer("g");
            }
        }
     
        public string SilverPrice
        {
            get
            {
                return GetResponseFromServer("s");
            }
        }
     
        public string DollarToRupee
        {
            get
            {
                return GetResponseFromServer("d");
            }
        }
     
        private string GetResponseFromServer(string input)
        {
            string result = string.Empty;
            using (TcpClient client = new TcpClient())
            {
                client.Connect("127.0.0.1", 9999);
     
                Stream stream = client.GetStream();
     
                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(input.ToCharArray());
     
                stream.Write(ba, 0, ba.Length);
     
                byte[] br = new byte[100];
                int k = stream.Read(br, 0, 100);
     
                
     
                for (int i = 0; i < k; i++)
                {
                    result += Convert.ToChar(br[i]);
                }
     
                client.Close();
            }
            return result;
        }
    }
    
    static void Main(string[] args)
    {
        IActualPrices proxy = new ActualPricesProxy();
     
        Console.WriteLine("Gold Price: ");
        Console.WriteLine(proxy.GoldPrice);
     
        Console.WriteLine("Silver Price: ");
        Console.WriteLine(proxy.SilverPrice);
     
        Console.WriteLine("Dollar to Ruppe Conversion: ");
        Console.WriteLine(proxy.DollarToRupee);
    }    
~~~	
#### Source:
* [codeproject](http://www.codeproject.com/Articles/492594/Understanding-and-Implementing-Proxy-Pattern-in-Cs)
* [oodesign](http://www.oodesign.com/proxy-pattern.html)
* [wikipedia](https://en.wikipedia.org/wiki/Proxy_pattern)