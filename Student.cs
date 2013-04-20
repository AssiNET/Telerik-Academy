using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public PersonalInformation PersonalInfo { get; set; }

        public bool IsOlderThan(Student student)
        {
            bool isOlder = false;
            DateTime firstStudent = this.PersonalInfo.BirthDate;
            DateTime secondStudent = student.PersonalInfo.BirthDate;

            if (firstStudent > secondStudent)
            {
                isOlder = true;
            }

            return isOlder;
        }
    }

    class PersonalInformation
    {
        public DateTime BirthDate { get; private set; }
        public string City { get; private set; }
        public string Hobby { get; private set; }

        public PersonalInformation(string birthDate, string city = null, string hobby = null)
        {
            if (!(DateTime.TryParse(birthDate, out this.BirthDate)))
            {
                throw new FormatException("Incorrect Date format! Suggest to (15.04.1999)");
            }
            this.City = city;
            this.Hobby = hobby;
        }
    }
}
