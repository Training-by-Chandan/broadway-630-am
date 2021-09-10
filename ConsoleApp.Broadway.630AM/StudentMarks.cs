namespace ConsoleApp.Broadway._630AM
{
    public class StudentMarks
    {
        //constructor is a special function 
        //it does not have return type
        //it has the same name as that of class
        //can have multiple constuctors but with different signature : Constructor Overloading
        //it can only be called once in a lifetime
        public StudentMarks()//parameterless contructor
        {
            FirstName = "Rahul";
            LastName = "Sharma";
        }

        public StudentMarks(string firstname)
        {
            FirstName = firstname;
            LastName = "Sharma";
        }

        public StudentMarks(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
      
        public string FirstName { get; private set; }

        private string _lastname;

        public string LastName
        {
            get
            {
                return _lastname + ".";
            }
            private set
            {
                if (value == "")
                {
                    value = "Default";
                }
                _lastname = value;
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string Intials
        {
            get
            {
                return FirstName.Substring(0, 1) + LastName.Substring(0, 1);
            }
        }

        public void AssignName(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public void AssignName(string firstname)
        {
            FirstName = firstname;
            LastName = "Sharma";
        }
    }
}