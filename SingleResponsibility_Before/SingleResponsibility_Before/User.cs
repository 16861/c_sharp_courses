namespace SingleResponsibility_Before
{
    public class User
    {
        public string PhoneNumber { get; }

        public User(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }
    }
}