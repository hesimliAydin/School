class Teacher
{
	public string? TeacherName { get; set; }
	public string? TeacherExperience { get; set; }
	public Group[]? groups { get; set; }
	public int CountGroup { get; set; }
	
	public static void WriteText(string text, int x, bool check)
	{
		if (check)
		{
			Console.Write(text);
			Console.ResetColor();
		}
		else
		{
			for (int i = 0; i < text.Length; i++)
				Console.Write(" ");
		}

		Console.CursorLeft -= text.Length;
		Thread.Sleep(x);
	}

	public void StartExam(string lessonName, string groupName)
	{
		foreach (var g in groups)
		{
			if (g.GroupName == groupName)
			{
				string fileName = "exam.txt";
				string path = Path.Combine(Environment.CurrentDirectory, fileName);
				string txt1 = "Exam is starting...";
				int count = 3;

				while (count != 0)
				{
					WriteText(txt1, 500, true);
					WriteText(txt1, 500, false);
					count--;
				}

				foreach (var st in g.students)
				{
					string txt2 = "Exam is finished !";
					int count1 = 6;
					while (count1 != 0)
					{
						WriteText(txt2, 500, true);
						WriteText(txt2, 500, false);
						count1--;
					}

					if (st?.Exam?.Score > 90)
					{
						Console.WriteLine($"{st.Name} {st.Surname}, Your score is {st.Exam.Score} A => (Excellent) from {lessonName} on {st.Exam.ExamTime}");
						Thread.Sleep(800);
						File.AppendAllText(path, $"Name : {st.Name} Surame : {st.Surname}, Your score is {st.Exam.Score}, {st.Exam.ExamTime}\n");
						Thread.Sleep(800);
					}
					else if (st?.Exam?.Score > 80)
					{
						Console.WriteLine($"{st.Name} {st.Surname}, Your score is {st.Exam.Score} B => (Very Good) from {lessonName} on {st.Exam.ExamTime}");
						Thread.Sleep(800);
						File.AppendAllText(path, $"Name : {st.Name} Surame : {st.Surname}, Your score is {st.Exam.Score}, {st.Exam.ExamTime}\n");
						Thread.Sleep(800);
					}
					else if (st?.Exam?.Score > 70)
					{
						Console.WriteLine($"{st.Name} {st.Surname}, Your score is {st.Exam.Score} C => (Good) from {lessonName} on {st.Exam.ExamTime}");
						Thread.Sleep(800);
						File.AppendAllText(path, $"Name : {st.Name} Surame : {st.Surname}, Your score is {st.Exam.Score}, {st.Exam.ExamTime}\n");
						Thread.Sleep(800);
					}
					else if (st?.Exam?.Score > 60)
					{
						Console.WriteLine($"{st.Name}  {st.Surname}, Your score is {st.Exam.Score} D(Enough) from {lessonName} on {st.Exam.ExamTime}");
						Thread.Sleep(800);
						File.AppendAllText(path, $"Name : {st.Name} Surame : {st.Surname}, Your score is {st.Exam.Score}, {st.Exam.ExamTime}\n");
						Thread.Sleep(800);
					}
					else if (st?.Exam?.Score > 50)
					{
						Console.WriteLine($"{st.Name} {st.Surname}, Your score is {st.Exam.Score} E => (Insufficient) from {lessonName} on {st.Exam.ExamTime}");
						Thread.Sleep(800);
						File.AppendAllText(path, $"Name : {st.Name} Surame : {st.Surname}, Your score is {st.Exam.Score}, {st.Exam.ExamTime}\n");
						Thread.Sleep(800);
					}
					else
					{
						Console.WriteLine($"{st.Name} {st.Surname}, Your score is {st.Exam.Score} F => (Failed) from {lessonName} on {st.Exam.ExamTime}");
						Console.WriteLine($"Sorry, You failed from {lessonName} exam : Good luck for future exam !");
						Thread.Sleep(800);
						File.AppendAllText(path, $"Name : {st.Name} Surame : {st.Surname}, Your score is {st.Exam.Score}, {st.Exam.ExamTime}\n");
						Thread.Sleep(800);
					}

					Console.WriteLine();
					Console.ResetColor();
				}

			}
		}
	}
	
	public void AddGroup(ref Group group)
	{
		var temp = new Group[++CountGroup];
		if (groups != null)
			groups.CopyTo(temp, 0);
		
		temp[temp.Length - 1] = group;
		groups = temp;
	}
	public void ShowTeacher()
	{
		Console.WriteLine("\n\n========== Teachers ==========\n");
		Console.WriteLine($"~ Teacher Name : {TeacherName}");
		Console.WriteLine($"~ Teacher Experience : {TeacherExperience}");
		
		foreach (var g in groups)
			g.ShowGroup();
		
		Console.WriteLine();
		Console.ResetColor();
	}
}