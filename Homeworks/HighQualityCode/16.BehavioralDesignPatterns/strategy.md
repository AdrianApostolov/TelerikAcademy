# Strategy Pattern

#### Мотивация
**Strategy Pattern** е **поведенчески (behavioral ) дизайн патърн**, който се използва, когато класовете се различават 
единствено по поведение - при тези случаи е добре алгоритмите да се изолират в отделни класове, за да могат да бъдат
избирани различни алгоритми по време на изпълнение.

#### Цел
* Дефинира семейство от алгоритми, енкапсулирайки всеки един, правейки ги взаимнозаменяеми
* Позволява алгоритъмът да варира независимо от клиетите, които го ползват

#### Структура 
 ![alt text] (https://combinatronics.com/AdrianApostolov/TelerikAcademy/master/Homeworks/HighQualityCode/16.BehavioralDesignPatterns/imgs/strategy-uml.png "Strategy UML Diagram")

#### Участниците в процеса:
- **Strategy** - дефинипа общ интерфейс за поддържните алгоритми. Контекстът (context)
го използва, за да извиква алгоритмите дефинирани от Concrete Strategy
- **Concrete Strategy** - всяка конкретна стратегия имплементира алгоритъм
- **Context** - съдържа референция към strategy; може да дефинира интерфейс, който да позволява strategy да достъпва данните му

#### Предимства
* Лесно разширяване на функционалността без модифициране

#### Приложение
* Когато класовете се различават единствено по поведение
* Като заместител на switch/if-else структури
* Когато добавянето на нова операция ще доведе до модифициране на клас

#### Пример
~~~c#
    public interface IBehaviour {
    	public int moveCommand();
    }
    
    public class AgressiveBehaviour implements IBehaviour{
    	public int moveCommand()
    	{
    		System.out.println("\tAgressive Behaviour: if find another robot attack it");
    		return 1;
    	}
    }
    
    public class DefensiveBehaviour implements IBehaviour{
    	public int moveCommand()
    	{
    		System.out.println("\tDefensive Behaviour: if find another robot run from it");
    		return -1;
    	}
    }
    
    public class NormalBehaviour implements IBehaviour{
    	public int moveCommand()
    	{
    		System.out.println("\tNormal Behaviour: if find another robot ignore it");
    		return 0;
    	}
    }
    
    public class Robot {
    	IBehaviour behaviour;
    	String name;
    
    	public Robot(String name)
    	{
    		this.name = name;
    	}
    
    	public void setBehaviour(IBehaviour behaviour)
    	{
    		this.behaviour = behaviour;
    	}
    
    	public IBehaviour getBehaviour()
    	{
    		return behaviour;
    	}
    
    	public void move()
    	{
    		System.out.println(this.name + ": Based on current position" +
    					 "the behaviour object decide the next move:");
    		int command = behaviour.moveCommand();
    		// ... send the command to mechanisms
    		System.out.println("\tThe result returned by behaviour object " +
    					"is sent to the movement mechanisms " + 
    					" for the robot '"  + this.name + "'");
    	}
    
    	public String getName() {
    		return name;
    	}
    
    	public void setName(String name) {
    		this.name = name;
    	}
    }
    
    
    public class Main {
    
    	public static void main(String[] args) {
    
    		Robot r1 = new Robot("Big Robot");
    		Robot r2 = new Robot("George v.2.1");
    		Robot r3 = new Robot("R2");
    
    		r1.setBehaviour(new AgressiveBehaviour());
    		r2.setBehaviour(new DefensiveBehaviour());
    		r3.setBehaviour(new NormalBehaviour());
    
    		r1.move();
    		r2.move();
    		r3.move();
    
    		System.out.println("\r\nNew behaviours: " +
    				"\r\n\t'Big Robot' gets really scared" +
    				"\r\n\t, 'George v.2.1' becomes really mad because" +
    				"it's always attacked by other robots" +
    				"\r\n\t and R2 keeps its calm\r\n");
    
    		r1.setBehaviour(new DefensiveBehaviour());
    		r2.setBehaviour(new AgressiveBehaviour());
    
    		r1.move();
    		r2.move();
    		r3.move();
    	}
    }
~~~
#### Source:
* [oodesign](http://www.oodesign.com/strategy-pattern.html)