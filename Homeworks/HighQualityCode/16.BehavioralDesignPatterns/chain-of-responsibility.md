# Chain of Responsibility Pattern

#### Мотивация
**Chain of Responsibility Pattern** е **поведенчески (behavioral ) дизайн патърн**, който позволява на един обект да
изпраща команда без да знае какъв обект ще я получи и обработи. Заявката се изпраща от един обект до друг,
правейки ги част от верига (chain) и всеки обект може да обработи командадата, да я предаде нататък или и двете. 

#### Цел
* Избягва връзването на изпращача на заявката към получателя, давайки възможност и на други обекти да я обработят
* Обектите стават част от верига и заявката се праща от един обект на друг, докато не бъде изпълнена
 
#### Структура 
 ![alt text] (https://rawgit.com/AdrianApostolov/TelerikAcademy/master/Homeworks/HighQualityCode/16.BehavioralDesignPatterns/imgs/chain-of-responsibility-uml.svg "Chain of Responsibility UML Diagram")

#### Участниците в процеса:
- **Handler** - дефинира интерфейс за обработване на заявки
- **Request Handler** - обработва заявките, за които е отговорен - ако може да обработи заявката го прави, ако не - предава на следващия
- **Client** - изпраща команда до пълвия обект във веригата, който може да я обработи 

#### Предимства
* Гъвкавост
* Намалява свързаността

#### Приложение
* Когато повече от един обект може да обработи командата
* Получателят не е известен предварително
* Получателят трябва да бъде определен автоматично

#### Пример

    using System;
     
    namespace DoFactory.GangOfFour.Chain.Structural
    {
      /// <summary>
      /// MainApp startup class for Structural
      /// Chain of Responsibility Design Pattern.
      /// </summary>
      class MainApp
      {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
          // Setup Chain of Responsibility
          Handler h1 = new ConcreteHandler1();
          Handler h2 = new ConcreteHandler2();
          Handler h3 = new ConcreteHandler3();
          h1.SetSuccessor(h2);
          h2.SetSuccessor(h3);
     
          // Generate and process request
          int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };
     
          foreach (int request in requests)
          {
            h1.HandleRequest(request);
          }
     
          // Wait for user
          Console.ReadKey();
        }
      }
     
      /// <summary>
      /// The 'Handler' abstract class
      /// </summary>
      abstract class Handler
      {
        protected Handler successor;
     
        public void SetSuccessor(Handler successor)
        {
          this.successor = successor;
        }
     
        public abstract void HandleRequest(int request);
      }
     
      /// <summary>
      /// The 'ConcreteHandler1' class
      /// </summary>
      class ConcreteHandler1 : Handler
      {
        public override void HandleRequest(int request)
        {
          if (request >= 0 && request < 10)
          {
            Console.WriteLine("{0} handled request {1}",
              this.GetType().Name, request);
          }
          else if (successor != null)
          {
            successor.HandleRequest(request);
          }
        }
      }
     
      /// <summary>
      /// The 'ConcreteHandler2' class
      /// </summary>
      class ConcreteHandler2 : Handler
      {
        public override void HandleRequest(int request)
        {
          if (request >= 10 && request < 20)
          {
            Console.WriteLine("{0} handled request {1}",
              this.GetType().Name, request);
          }
          else if (successor != null)
          {
            successor.HandleRequest(request);
          }
        }
      }
     
      /// <summary>
      /// The 'ConcreteHandler3' class
      /// </summary>
      class ConcreteHandler3 : Handler
      {
        public override void HandleRequest(int request)
        {
          if (request >= 20 && request < 30)
          {
            Console.WriteLine("{0} handled request {1}",
              this.GetType().Name, request);
          }
          else if (successor != null)
          {
            successor.HandleRequest(request);
          }
        }
      }
    }
	
#### Source:
* [codeproject](http://www.codeproject.com/Articles/743783/Reusable-Chain-of-responsibility-in-Csharp)
* [oodesign](http://www.oodesign.com/chain-of-responsibility-pattern.html)