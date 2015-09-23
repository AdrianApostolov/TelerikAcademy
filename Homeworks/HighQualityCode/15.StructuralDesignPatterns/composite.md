# Composite Pattern

#### Мотивация
**Composite Pattern** е **структурен (structural) дизайн патърн**, който позволява манипулирането на дървовидна
структура и е необходимо клоните, както и листата да бъдат третирани равномерно (например файлова структура).

#### Цел
* Да композира обекти в дървовидни структури, които да представят йерархия
* Дава възможност индивидуални обекти и композиции от обекти да бъдат третирани равномерно
 
#### Структура 
 ![alt text](https://github.com/AdrianApostolov/TelerikAcademy/blob/master/Homeworks/HighQualityCode/15.StructuralDesignPatterns/imgs/composite-uml.svg "Composite UML Diagram")

#### Участниците в процеса:
- **Component** - абстракция на листа (leafs) и композиции; дефинира интерфейса, който трябва да бъде имплементиран от обектите
в композицията
- **Leaf** - листата са обекти, които нямат деца; имплементират услугите, описани в component интерфейса
- **Composite** - съхранява децата, в допълнение към имплементирането на методите, 
дефиинирани от component интерфейса - като делегира на децата; предоставя и допълнителни методи за добавяне, премахване и достъпване на компоненти

#### Предимства
* Лесно добавяне на нови компоненти без модифициране

#### Приложение
* Когато е налице йерархия от обекти и клинета трябва да ги разглежда равномерно, независимо дали обекта е клон или листо

#### Пример

    using System;
    using System.Collections.Generic;
     
    namespace DoFactory.GangOfFour.Composite.Structural
    {
      /// <summary>
      /// MainApp startup class for Structural 
      /// Composite Design Pattern.
      /// </summary>
      class MainApp
      {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
          // Create a tree structure
          Composite root = new Composite("root");
          root.Add(new Leaf("Leaf A"));
          root.Add(new Leaf("Leaf B"));
     
          Composite comp = new Composite("Composite X");
          comp.Add(new Leaf("Leaf XA"));
          comp.Add(new Leaf("Leaf XB"));
     
          root.Add(comp);
          root.Add(new Leaf("Leaf C"));
     
          // Add and remove a leaf
          Leaf leaf = new Leaf("Leaf D");
          root.Add(leaf);
          root.Remove(leaf);
     
          // Recursively display tree
          root.Display(1);
     
          // Wait for user
          Console.ReadKey();
        }
      }
     
      /// <summary>
      /// The 'Component' abstract class
      /// </summary>
      abstract class Component
      {
        protected string name;
     
        // Constructor
        public Component(string name)
        {
          this.name = name;
        }
     
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
      }
     
      /// <summary>
      /// The 'Composite' class
      /// </summary>
      class Composite : Component
      {
        private List<Component> _children = new List<Component>();
     
        // Constructor
        public Composite(string name)
          : base(name)
        {
        }
     
        public override void Add(Component component)
        {
          _children.Add(component);
        }
     
        public override void Remove(Component component)
        {
          _children.Remove(component);
        }
     
        public override void Display(int depth)
        {
          Console.WriteLine(new String('-', depth) + name);
     
          // Recursively display child nodes
          foreach (Component component in _children)
          {
            component.Display(depth + 2);
          }
        }
      }
     
      /// <summary>
      /// The 'Leaf' class
      /// </summary>
      class Leaf : Component
      {
        // Constructor
        public Leaf(string name)
          : base(name)
        {
        }
     
        public override void Add(Component c)
        {
          Console.WriteLine("Cannot add to a leaf");
        }
     
        public override void Remove(Component c)
        {
          Console.WriteLine("Cannot remove from a leaf");
        }
     
        public override void Display(int depth)
        {
          Console.WriteLine(new String('-', depth) + name);
        }
      }
    }    
	
#### Source:
* [dofactory](http://www.dofactory.com/net/composite-design-pattern)
* [oodesign](http://www.oodesign.com/composite-pattern.html)
* [wikipedia](https://en.wikipedia.org/wiki/Composite_pattern)