namespace Cooking
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegetable>();
        }

        public List<Vegetable> Ingredients { get; set; }

        public void Add(Vegetable vegetable)
        {
            this.Ingredients.Add(vegetable);
        }
    }
}
