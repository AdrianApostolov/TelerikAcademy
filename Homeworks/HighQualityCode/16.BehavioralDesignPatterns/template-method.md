# Template Method Pattern

#### Мотивация
**Template Method Pattern** е **поведенчески (behavioral ) дизайн патърн** на принципа на темплейтите, който дефинира алгоритъм в базов клас,
използвайки абстрактни операции, които под-класове да овъррайдват, за да осигурят конкретно поведение.

#### Цел
* Дефинира скелета на алгоритъм в една операция, оставяйки някои стъпки на под-класове
* Оставя под-класовете да ре-дефинират определени стъпки на алгоритъма, без да променят неговата структура

#### Структура 
 ![alt text] (https://rawgit.com/AdrianApostolov/TelerikAcademy/master/Homeworks/HighQualityCode/16.BehavioralDesignPatterns/imgs/template-method-uml.svg "Template Method UML Diagram")

#### Участниците в процеса:
- **Abstract Class** - имплементира темплейтен метод, който дефинира скелета на алгоритъм; дефинира абстрактни примитивни операции, които конкретните класове дефинират, за да имплементира стъпки от алгоритъм
- **ConcreteClass** - имплементира примитивни операции, за да изпълни специфичните за под-класа стъпки от алгоритъма 

#### Предимства
* Намалява се възможността от дуплициране на код
* Наследяване и полиморфизъм

#### Приложение
* Когато непроменяеми части от алгоритъм се имплементират веднъж и се оставя на под-класовете да имплементират 
поведението, което може да се различава
* При рефакториране, когато се установи общо поведение сред класове

#### Пример

    using System;
    
      class MainApp
      {
        static void Main()
        {
          AbstractClass c;
     
          c = new ConcreteClassA();
          c.TemplateMethod();
    
          c = new ConcreteClassB();
          c.TemplateMethod();
    
          // Wait for user 
          Console.Read();
        }
      }
    
      // "AbstractClass"
      abstract class AbstractClass
      {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
    
        // The "Template method" 
        public void TemplateMethod()
        {
          PrimitiveOperation1();
          PrimitiveOperation2();
          Console.WriteLine("");
        }
      }
    
      // "ConcreteClass" 
      class ConcreteClassA : AbstractClass
      {
        public override void PrimitiveOperation1()
        {
          Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
          Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
        }
      }
    
      class ConcreteClassB : AbstractClass
      {
        public override void PrimitiveOperation1()
        {
          Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");
        }
        public override void PrimitiveOperation2()
        {
          Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
        }
      }

#### Source:
* [oodesign](http://www.oodesign.com/template-method-pattern.html)
* [sourcemaking](https://sourcemaking.com/design_patterns/template_method/c-sharp-dot-net)
* [wikipedia](https://en.wikipedia.org/wiki/Template_method_pattern)