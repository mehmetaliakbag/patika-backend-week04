using _01SchoolManagementSystem;

Person student1 = new Person();

student1.Name = "Wolfgang";
student1.Surname = "Mozart";
student1.DateOfBirth = new DateTime(2008, 12, 13);

student1.GetPersonDetails();

Person student2 = new Person();
student2.Name = "Ludwig";
student2.Surname = "Beethoven";
student2.DateOfBirth = new DateTime(2009, 04, 23);

student2.GetPersonDetails();

Person teacher1 = new Person();
teacher1.Name = "Plato";
teacher1.Surname = "Idea";
teacher1.DateOfBirth = new DateTime(1990, 10, 10);

teacher1.GetPersonDetails();

Person teacher2 = new Person();
teacher2.Name = "Aristo";
teacher2.Surname = "Reality";
teacher2.DateOfBirth = new DateTime(1999, 2, 28);

teacher2.GetPersonDetails();
