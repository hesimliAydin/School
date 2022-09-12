class Student
{
	public Guid ID { get; set; }
	public string? Name { get; set; }
	public string? Surname { get; set; }
	public int Age { get; set; }
	public Exam? Exam { get; set; }

	public void ShowStudent()
	{
		Console.WriteLine("\n\n========== Students ==========");
		Console.WriteLine($"ID : {ID}");
		Console.WriteLine($"Name : {Name}");
		Console.WriteLine($"Surname : {Surname}");
		Console.WriteLine($"Age : {Age}");
		
		Console.WriteLine();
		Console.ResetColor();
	}
}