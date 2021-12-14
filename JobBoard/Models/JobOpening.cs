using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    public string Title { get; }
    public string Description { get; }
    public Contact JobContact { get; }

    public static List<JobOpening> Jobs { get; } = new List<JobOpening> {};
    public JobOpening(string title, string description, string name, string email, string phone)
    {
      Title = title;
      Description = description;
      JobContact = new Contact(name, email, phone);
      Jobs.Add(this);
    }

    public class Contact
    {
      public string Name { get; }
      public string Email { get; }
      public string PhoneNumber { get; }
      public Contact(string name, string email, string phone)
      {
        Name = name;
        Email = email;
        PhoneNumber = phone;
      }
    } 
  }
}