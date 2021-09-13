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

        public double MathMarks { get; set; }
        public double ScienceMarks { get; set; }
        public double EnglishMarks { get; set; }

        #region Operator Overloading

        public static StudentMarks operator +(StudentMarks s1, StudentMarks s2)
        {
            return new StudentMarks(s1.FirstName, s1.LastName)
            {
                MathMarks = s1.MathMarks + s2.MathMarks,
                ScienceMarks = s1.ScienceMarks + s2.ScienceMarks,
                EnglishMarks = s1.EnglishMarks + s2.EnglishMarks
            };
        }

        public static StudentMarks operator -(StudentMarks s1, StudentMarks s2)
        {
            return new StudentMarks(s1.FirstName, s1.LastName)
            {
                MathMarks = s1.MathMarks - s2.MathMarks,
                ScienceMarks = s1.ScienceMarks - s2.ScienceMarks,
                EnglishMarks = s1.EnglishMarks - s2.EnglishMarks
            };
        }

        public static StudentMarks operator ++(StudentMarks s1)
        {
            s1.MathMarks++;
            s1.EnglishMarks++;
            s1.ScienceMarks++;
            return s1;
        }

        public static bool operator ==(StudentMarks s1, StudentMarks s2)
        {
            return s1.MathMarks == s2.MathMarks && s1.ScienceMarks == s2.ScienceMarks && s1.EnglishMarks == s2.EnglishMarks;
        }

        public static bool operator !=(StudentMarks s1, StudentMarks s2)
        {
            return !(s1.MathMarks == s2.MathMarks && s1.ScienceMarks == s2.ScienceMarks && s1.EnglishMarks == s2.EnglishMarks);
        }

        public static StudentMarks operator +(StudentMarks s1, int i)
        {
            s1.MathMarks = s1.MathMarks + i;
            s1.ScienceMarks = s1.ScienceMarks + i;
            s1.EnglishMarks = s1.EnglishMarks + i;
            return s1;
        }

        #endregion Operator Overloading
    }
}