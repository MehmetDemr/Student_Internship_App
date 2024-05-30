using System;

namespace KuyrukUygulama
{
    public class Student : IComparable<Student>
    {
        public int StudentNumber { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public string RoleInOrganizations { get; set; }
        public int Absenteeism { get; set; }

        public Student(int studentNumber, string name, double gpa, string roleInOrganizations, int absenteeism)
        {
            StudentNumber = studentNumber;
            Name = name;
            GPA = gpa;
            RoleInOrganizations = roleInOrganizations;
            Absenteeism = absenteeism;
        }

        // Method to compare this student with another student based on GPA, role in organizations, and absenteeism
        public int CompareTo(Student other)
        {
            // Compare GPA of this student with GPA of the other student
            if (GPA != other.GPA)
                return other.GPA.CompareTo(GPA); // Return the result of comparing GPAs in descending order

            // If GPA is equal, compare role in organizations of this student with role in organizations of the other student
            if (RoleInOrganizations != other.RoleInOrganizations)
                return other.RoleInOrganizations.CompareTo(RoleInOrganizations); // Return the result of comparing roles in organizations in descending order

            // If both GPA and role in organizations are equal, compare absenteeism of this student with absenteeism of the other student
            return Absenteeism.CompareTo(other.Absenteeism); // Return the result of comparing absenteeism in ascending order
        }


        public override string ToString()
        {
            return $"{StudentNumber} - {Name} - GPA: {GPA}, Joined: {RoleInOrganizations}, Absenteeism: {Absenteeism}";
        }
    }
}
