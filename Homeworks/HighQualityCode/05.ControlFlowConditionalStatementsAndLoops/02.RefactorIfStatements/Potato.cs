namespace RefactorIfStatements
{
    public class Potato
    {
        private bool isRotten;
        private bool isPeeled;

        public Potato(bool isRotten, bool isPeeled)
        {
            this.IsRotten = isRotten;
            this.IsPeeled = isPeeled;
        }

        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }
    }
}
