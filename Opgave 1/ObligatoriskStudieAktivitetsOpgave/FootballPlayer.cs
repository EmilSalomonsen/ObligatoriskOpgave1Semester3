using System;

namespace ObligatoriskStudieAktivitetsOpgave
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string _name;
        public int _price;
        public int _shirtnumber;
        public string Name
        { 
            get => _name; 
            set
            {
                if (value.Length < 4) throw new ArgumentException("Name has to be 4 or more characters long");
                    _name = value;
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value <= 0) throw new ArgumentException("Price has to be over 0");
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtnumber;
            set
            {
                if (value <= 1 || value >= 100) throw new ArgumentException("Shirt number has to be between 1 and 100");
                _shirtnumber = value;
            }
        }

    }
}
