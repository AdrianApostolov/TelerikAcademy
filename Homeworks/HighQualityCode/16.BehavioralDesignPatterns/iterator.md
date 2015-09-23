# Iterator Pattern

#### Мотивация
**Iterator Pattern** е **поведенчески (behavioral ) дизайн патърн**, който позволява достъпване и преминаване през 
обектите на колекция и добавянето им в обект-итератор. Обектът-итератор пази състоянието на итерирането, следи 
текущия обект и идентифицира кои са следващите елементи за итериране. 

#### Цел
* Осигурява начин за достъп до елементите на агрегиран обект (колекция) последователно, без да експоузва репрезентацията и отдолу
 
#### Структура 
 ![alt text] (https://rawgit.com/AdrianApostolov/TelerikAcademy/master/Homeworks/HighQualityCode/16.BehavioralDesignPatterns/imgs/iterator-uml.svg "Iterator UML Diagram")

#### Участниците в процеса:
- **IIterator** - интерфейс, който репрезентира абстрактния итератор, дефиниращ итератора
- **Book Iterator** - имплементация на итератора (имплементира IIterator интерфейса)
- **IContainer** - интерфейс, дефиниращ агрегата
- **BooksCollection** - имплементация на колекция

#### Предимства
* Сигурност
* Абстракция - еднакъв интерфейс за итерирането на различни колекции

#### Приложение
* Когато трябва да се достъпи съдържанието на колекция, без експоузването на вътрешната и структура

#### Пример
~~~c#
    interface IIterator
    {
    	public boolean hasNext();
    	public Object next();
    }
    
    interface IContainer
    {
    	public IIterator createIterator();
    }
    
    class BooksCollection implements IContainer
    {
    	private String m_titles[] = {"Design Patterns","1","2","3","4"};
    
    	public IIterator createIterator()
    	{
    		BookIterator result = new BookIterator();
    		return result;
    	}
    
    
    	private class BookIterator implements IIterator
    	{
    		private int m_position;
    
    		public boolean hasNext()
    		{
    			if (m_position < m_titles.length)
    				return true;
    			else
    				return false;
    		}
    		public Object next()
    		{
    			if (this.hasNext())
    				return m_titles[m_position++];
    			else
    				return null;
    		}
    	}
    }
~~~
#### Source:
* [oodesign](http://www.oodesign.com/iterator-pattern.html)