namespace CompanyManagement.Domain.Entities;

public class Company
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;  
    public DateTime EstablishedOn { get; private set; }

    private Company() { }  

    public Company(string name, DateTime establishedOn)
    {
        Id = Guid.NewGuid();
        Name = name;
        EstablishedOn = establishedOn;
    }

    public void Rename(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentException("Name cannot be empty");

        Name = newName;
    }
}
