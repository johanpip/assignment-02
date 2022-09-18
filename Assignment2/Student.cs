namespace Assignment2
{
    public class Student
    {
        public int Id { get; private set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public Status Status { get; private set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime GraduationDate { get; set; }

        public Student(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            Id = id;
            GivenName = givenName;
            Surname = surName;
            StartDate = startDate;
            EndDate = endDate;
            GraduationDate = graduationDate;
            Status = CalculateStatus();
        }

        public Status CalculateStatus()
        {
            if (StartDate > DateTime.Now) return Status.New;
            if (EndDate > DateTime.Now) return Status.Active;
            if (GraduationDate != EndDate) return Status.Dropout;

            return Status.Graduated;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {GivenName}, Surname: {Surname}, Status: {Status}, StartDate: {StartDate}, EndDate: {EndDate}, GraduationDate: {GraduationDate}";
        }
    }

    public enum Status
    {
        New,
        Active,
        Dropout,
        Graduated
    }

}