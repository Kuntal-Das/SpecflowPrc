namespace specflowPrc1
{
    public class EmployeeDetails
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"\nName: {Name}\nPhone: {Phone}\nAge: {Age}\nEmail: {Email}";
        }
    }
}