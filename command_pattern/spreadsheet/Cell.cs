namespace Spreadsheet_CommandPattern
{

    public class Cell
    {
        private string _name;
        private int _value;

        public string Name
        {
            get { return this._name; }
        }
        public int Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        public Cell(string name, int value)
        {
            this._name = name;
            this._value = value;
        }
        
    }
}