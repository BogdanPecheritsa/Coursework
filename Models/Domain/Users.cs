namespace CALLОМОЙСЬКИЙ.Models.Domain;

public class Users
{
    public Guid Id { get; set; }
    public string PhoneNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public List<Calls> Calls { get; set; }
    public List<Messages> Messages { get; set; }
    public List<Contacts> Contacts { get; set; }
}