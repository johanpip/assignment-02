namespace Assignment2
{
public record ImmutableStudent(int Id, string GivenName, string Surname, DateTime StartDate, DateTime EndDate, DateTime GraduationDate){
        
        public Status Status { get; private set; }
        
        public Status CalculateStatus()
        {
            if (StartDate > DateTime.Now) return Status.New;
            if (EndDate > DateTime.Now) return Status.Active;
            if (GraduationDate != EndDate) return Status.Dropout;

            return Status.Graduated;
        }

        public override string ToString()
        {
            Status = CalculateStatus();
            return $"Id: {Id}, Name: {GivenName}, Surname: {Surname}, Status: {Status}, StartDate: {StartDate}, EndDate: {EndDate}, GraduationDate: {GraduationDate}";
        }
    }
}
//(int id = default, string givenName = null, string surName = null, DateTime startDate = default, DateTime endDate = default, DateTime graduationDate = default