class School
{
	public string? Name { get; set; }
	public Teacher[]? teachers { get; set; }
	public int CountTeacher { get; set; }
	
	public void AddTeacher(ref Teacher teacher)
	{
		var newTeacher = new Teacher[++CountTeacher];

		if (teachers != null)
			teachers.CopyTo(newTeacher, 0);

		newTeacher[newTeacher.Length - 1] = teacher;
		teachers = newTeacher;
	}
	
	public void ShowSchool()
	{
		Console.WriteLine("========== SCHOOL ==========");
		Console.WriteLine($"~ School Name : {Name}");

		foreach (var t in teachers)
			t.ShowTeacher();
		
		Console.WriteLine();
		Console.ResetColor();
	}
}