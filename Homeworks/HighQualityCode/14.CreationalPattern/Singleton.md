# Creational Design Patterns

## Singleton
Това е Design Pattern, който нарушава някой от ООП принципи (и SOLID _single responsibility_). Затова този патърн носи със себе си 'тежести', проблеми за отстраняване.

* **Мотивация:**
	- Използва се за неща, които са глобални и единствени за приложението

* **Цел:**
	- Подсигурява се създаването от класа на единствена инстанция и също глобален достъп до нея

* **Приложение:**
	- Highscore (в игрите)
	- file system

* **Известни употреби:**
	- window manager, file system, logger

* **Имплементация** (реално изпълнение)
	* Singleton - First version

	~~~c#
	public sealed class Singleton
	{
	    private static Singleton instance = null;

	    private Singleton()
	    {
	    }

	    public static Singleton Instance
	    {
	        get
	        {
	            if (instance==null)
	            {
	                instance = new Singleton();
	            }
	            return instance;
	        }
	    }
	}
	~~~

	* Singleton - Second version _simple thread-safety_
	Becouse two different threads could both have evaluated the test if (instance == null) and found it to be true.

	~~~c#
	public sealed class Singleton
	{
	    private static Singleton instance = null;
	    private static readonly object padlock = new object();

	    Singleton()
	    {
	    }

	    public static Singleton Instance
	    {
	        get
	        {
	            lock (padlock)
	            {
	                if (instance == null)
	                {
	                    instance = new Singleton();
	                }
	                return instance;
	            }
	        }
	    }
	}
	~~~

* **Участници**
	- В общия случай не се разрешени настройки на параметрите

* **Последствия**
	* базовата имплементация (non thread-safe)
		не може да се използва в многонишкова среда

	* tight coupling
		зависим от този клас (_Singleton_)

* **Структура**

![Singleton](images/Singleton.jpg "Singleton - UML diagram")

* **Проблеми**
	- Да не се създава предварително, а в първият момент когато бъде извикана инстанцията
	- Използването на няколко нишки
	- Много силен каплинг