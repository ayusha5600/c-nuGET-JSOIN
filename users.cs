#nullable enable

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }

    public User(string name, int age, string city)
    {
        Name = name ?? string.Empty;
        Age = age;
        City = city ?? string.Empty;
    }
}

public class AdminUser : User
{
    public string AdminRole { get; set; }

    public AdminUser(string name, int age, string city, string adminRole)
        : base(name, age, city)
    {
        AdminRole = adminRole ?? string.Empty;
    }
}

public class RegularUser : User
{
    public string SubscriptionType { get; set; }

    public RegularUser(string name, int age, string city, string subscriptionType)
        : base(name, age, city)
    {
        SubscriptionType = subscriptionType ?? string.Empty;
    }
}
