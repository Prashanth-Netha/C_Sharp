using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


public class Person1
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Address HomeAddress { get; set; }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}


/*
 *  XML Serialization
XML serialization converts an object into an XML format. It's human-readable and useful for interoperability.
*/


class SerializationExample
{
    static void Main()
    {
        Person person = new Person { Name = "John", Age = 30 };

        // Serialize
        using (FileStream stream = new FileStream("D:\\Desktop\\C#\\ISerialisation&Deserialisation\\serialiseanddeserialise\\person.xml", FileMode.Create))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            serializer.Serialize(stream, person);
        }

        // Deserialize
        using (FileStream stream = new FileStream("D:\\Desktop\\C#\\ISerialisation&Deserialisation\\serialiseanddeserialise\\person.xml", FileMode.Open))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            Person deserializedPerson = (Person)serializer.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }


        //        JSON Serialization
        //JSON serialization converts an object into a JSON format.It's human-readable and widely used for web applications.

        try
        {
            Person1 person1 = new Person1
            {
                Name = "John",
                Age = 30,
                HomeAddress = new Person1.Address
                {
                    Street = "123 Main St",
                    City = "Anytown",
                    State = "Anystate",
                    ZipCode = "12345"
                }
            };

            // Serialize
            string jsonString = JsonSerializer.Serialize(person1, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("D:\\Desktop\\C#\\ISerialisation&Deserialisation\\serialiseanddeserialise\\person1.json", jsonString);

            // Deserialize
            jsonString = File.ReadAllText("D:\\Desktop\\C#\\ISerialisation&Deserialisation\\serialiseanddeserialise\\person1.json");
            Person1 deserializedPerson1 = JsonSerializer.Deserialize<Person1>(jsonString);

            Console.WriteLine($"Name: {deserializedPerson1.Name}, Age: {deserializedPerson1.Age}");
            Console.WriteLine($"Address: {deserializedPerson1.HomeAddress.Street}, {deserializedPerson1.HomeAddress.City}, {deserializedPerson1.HomeAddress.State} {deserializedPerson1.HomeAddress.ZipCode}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

    }
}
