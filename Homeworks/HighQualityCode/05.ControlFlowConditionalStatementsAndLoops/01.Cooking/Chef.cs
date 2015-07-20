namespace Cooking
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Cut(Vegetable vegetable)
        {
            throw new System.NotImplementedException();
        }

        private void Peel(Vegetable vegetable)
        {
            throw new System.NotImplementedException();
        }
    }
}
