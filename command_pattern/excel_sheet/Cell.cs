namespace Excel_Sheet_CommandPattern{

    public class Cell
    {   
        //public string Name { get; set; }
        //public int Value { get; set; }

        public Cell(string name, int value = 0)
        {
            Name = name;
            Value = value;
        }

        /*public override string ToString()
        {
            return $"{Name}: {Value}";
        }*/
    }

}