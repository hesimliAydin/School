class Group
{
	public string? GroupName { get; set; }
	public Student[]? students { get; set; }
	public int CountStudent { get; set; } = 0;
	
	public void AddStudent(ref Student student)
	{
		var add = new Student[++CountStudent];
		if (students != null)
			students.CopyTo(add, 0);

		add[add.Length - 1] = student;
		students = add;
	}
	public void ShowGroup()
	{
		Console.WriteLine("\n\n========== Groups ==========");
		Console.WriteLine($"~ Group Name : {GroupName}");
		
		foreach (var s in students)
			s.ShowStudent();
		
		Console.WriteLine();
		Console.ResetColor();
	}
}