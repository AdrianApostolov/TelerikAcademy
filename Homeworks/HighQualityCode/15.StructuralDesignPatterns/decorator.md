# Decorator Pattern

#### Мотивация
**Decorator Pattern** е **структурен (structural) дизайн патърн**, който позволява разширяването на функционалността 
на обект динамично - по време на изпълнение.

#### Цел
* Да добавя допълнителни отговорности към обекта динамично, по време на изпълнение
 
#### Структура 
 ![alt text] (https://github.com/AdrianApostolov/TelerikAcademy/blob/master/Homeworks/HighQualityCode/15.StructuralDesignPatterns/imgs/decorator-uml.svg "Decorator UML Diagram")

#### Участниците в процеса:
- **Component** - интерфейс на обектите, които могат да бъдат променяни динамично
- **Concrete Component** - дефинира обект, към който могат да се добавят допълнителни отговорности
- **Decorator** - съдържа референция към component и дефинира интерфейс, който съответства на component интерфейса
- **Concrete Decorators** - разширява функционалността на компонента като добавя състояние или поведение

#### Предимства
* Гъвкавост
* Алтернатива на използването ва под-класовете

#### Приложение
* Когато е необходимо добавянето на допълнителни отговорности по време на изпълнение (например GUI)

#### Пример

    public abstract class BakeryComponent
    {
        public abstract string GetName();
        public abstract double GetPrice();
    }
    
    class CakeBase : BakeryComponent
    {
        // In real world these values will typically come from some data store
        private string m_Name = "Cake Base";
        private double m_Price = 200.0;
    
        public override string GetName()
        {
            return m_Name;
        }
    
        public override double GetPrice()
        {
            return m_Price;
        }
    }
    
    class PastryBase : BakeryComponent
    {
        // In real world these values will typically come from some data store
        private string m_Name = "Pastry Base";
        private double m_Price = 20.0;
    
        public override string GetName()
        {
            return m_Name;
        }
    
        public override double GetPrice()
        {
            return m_Price;
        }
    }
    
    public abstract class Decorator : BakeryComponent
    {
        BakeryComponent m_BaseComponent = null;
        
        protected string m_Name = "Undefined Decorator";
        protected double m_Price = 0.0;
    
        protected Decorator(BakeryComponent baseComponent)
        {
            m_BaseComponent = baseComponent;
        }
    
        string BakeryComponent.GetName()
        {
            return string.Format("{0}, {1}", m_BaseComponent.GetName(), m_Name);
        }
    
        double BakeryComponent.GetPrice()
        {
            return m_Price + m_BaseComponent.GetPrice();
        }
    }
    
    class ArtificialScentDecorator : Decorator
    {
        public ArtificialScentDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Artificial Scent";
            this.m_Price = 3.0;
        }
    }
    
    class CherryDecorator : Decorator
    {
        public CherryDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cherry";
            this.m_Price = 2.0;
        }
    }
    
    class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cream";
            this.m_Price = 1.0;
        }
    }
    
    class NameCardDecorator : Decorator
    {
        private int m_DiscountRate = 5;
    
        public NameCardDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Name Card";
            this.m_Price = 4.0;
        }
    
        public override string GetName()
        {
            return base.GetName() + 
                string.Format("\n(Please Collect your discount card for {0}%)", 
                m_DiscountRate);
        }        
    }
    
    static void Main(string[] args)
    {
        // Let us create a Simple Cake Base first
        CakeBase cBase = new CakeBase();
        PrintProductDetails(cBase);
    
        // Lets add cream to the cake
        CreamDecorator creamCake = new CreamDecorator(cBase);
        PrintProductDetails(creamCake);
        
        // Let now add a Cherry on it
        CherryDecorator cherryCake = new CherryDecorator(creamCake);
        PrintProductDetails(cherryCake);
    
        // Lets now add Scent to it
        ArtificialScentDecorator scentedCake = new ArtificialScentDecorator(cherryCake);
        PrintProductDetails(scentedCake);
    
        // Finally add a Name card on the cake
        NameCardDecorator nameCardOnCake = new NameCardDecorator(scentedCake);
        PrintProductDetails(nameCardOnCake);
        
        // Lets now create a simple Pastry
        PastryBase pastry = new PastryBase();
        PrintProductDetails(pastry);
    
        // Lets just add cream and cherry only on the pastry 
        CreamDecorator creamPastry = new CreamDecorator(pastry);
        CherryDecorator cherryPastry = new CherryDecorator(creamPastry);
        PrintProductDetails(cherryPastry);
    }
	
#### Source:
* [codeproject](http://www.codeproject.com/Articles/479635/UnderstandingplusandplusImplementingplusDecoratorp)
* [oodesign](http://www.oodesign.com/decorator-pattern.html)
* [wikipedia](https://en.wikipedia.org/wiki/Decorator_pattern)