namespace FirstTutorial
{
    public class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa) {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public void HasHonors(double gpa) {
            if(gpa >= 3.5) {
                Console.WriteLine(name + " has passed");
            }else {
                Console.WriteLine(name + " has failed");
            }
        }
    }
}