using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonUserEditor
{
    // Base class
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }

    // Admin class
    public class Admin : User
    {
        public string Role { get; set; } = "Admin";
    }

    // GeneralUser class
    public class GeneralUser : User
    {
        public string AccessLevel { get; set; } = "Standard";
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "users.json";

            // Step 1: Load existing users or create new list
            string existingJson = File.Exists(filePath) ? File.ReadAllText(filePath) : "[]";
            var users = JsonConvert.DeserializeObject<List<User>>(existingJson) ?? new List<User>();

            // Step 2: Add new users only if not already added
            bool userExists(string name, int age)
            {
                return users.Exists(u => u.Name == name && u.Age == age);
            }

            if (!userExists("Charlie", 40))
                users.Add(new Admin { Name = "Charlie", Age = 40 });

            if (!userExists("Daisy", 25))
                users.Add(new GeneralUser { Name = "Daisy", Age = 25 });

            // Step 3: Save updated list
            File.WriteAllText(filePath, JsonConvert.SerializeObject(users, Formatting.Indented));
            Console.WriteLine("Users updated and saved!");

            // Step 4: Display all users
            var loadedUsers = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(filePath));

            if (loadedUsers != null)
            {
                Console.WriteLine("\n All Users:");
                foreach (var user in loadedUsers)
                {
                    Console.WriteLine($"Name: {user.Name}, Age: {user.Age}");
                }
            }
        }
    }
}
