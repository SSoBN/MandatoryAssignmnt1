using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MandatoryAssignmnt1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public FootballPlayer()
        {

        }
        public FootballPlayer(int id, string name, int age, int shirtNumber  )
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public void ValidateName()
        {
            if (Name == null) throw new ArgumentNullException("Navn er null");
            if (Name.Length < 2) throw new ArgumentOutOfRangeException("Navn skal indeholde mindst 2 tegn");
        }

        public void ValidateAge()
        {
            if (Age < 2) throw new ArgumentOutOfRangeException("Alder skal være mere end 1 år");
        }

        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99) throw new ArgumentOutOfRangeException("Spiller-nummeret skal være mellem 1 og 99");
        }
    }
}
