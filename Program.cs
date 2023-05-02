using EFCore_Console;

using (ApplicationContext db = new ApplicationContext())
{
    User tom = new User { Name = "Tom", Age = 15};
    User alice = new User { Name = "Alice", Age = 15};

    db.Users.Add(alice);
    db.Users.Add(tom);
    db.SaveChanges();
    Console.WriteLine("OK");

    var users = db.Users.ToList();
    Console.WriteLine("Список людей:");
    foreach(User u in users)
    {
        Console.WriteLine($"{u.ID}.{u.Name} - {u.Age}");
    }
}