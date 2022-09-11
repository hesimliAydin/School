partial class Program
{
	static void Main()
	{
		Random random = new Random();

		int count = 4;
		int[] scores = new int[count];
		for (int i = 0; i < count; i++)
			scores[i] = random.Next(0, 100);

		Exam exam1 = new Exam
		{
			Lesson = "Mathemathics",
			Score = scores[0],
			ExamTime = new DateTime(2021, 06, 25, 09, 00, 00)
		};

		Exam exam2 = new Exam
		{
			Lesson = "History",
			Score = scores[1],
			ExamTime = new DateTime(2021, 06, 25, 09, 40, 00)
		};

		Exam exam3 = new Exam
		{
			Lesson = "Chemistry",
			Score = scores[2],
			ExamTime = new DateTime(2021, 06, 25, 10, 20, 00)
		};

		Exam exam4 = new Exam
		{
			Lesson = "Biology",
			Score = scores[2],
			ExamTime = new DateTime(2021, 06, 25, 10, 20, 00)
		};

		Student student1 = new Student
		{
			ID = Guid.NewGuid(),
			Name = "Aydin",
			Surname = "Hesimli",
			Age = 20,
			Exam = exam1
		};

		Student student2 = new Student
		{
			ID = Guid.NewGuid(),
			Name = "Eli",
			Surname = "Tagiyev",
			Age = 23,
			Exam = exam2
		};

		Student student3 = new Student
		{
			ID = Guid.NewGuid(),
			Name = "Ruslan",
			Surname = "Necefli",
			Age = 20,
			Exam = exam3
		};

		Student student4 = new Student
		{
			ID = Guid.NewGuid(),
			Name = "Murad",
			Surname = "Agayev",
			Age = 20,
			Exam = exam4
		};

		Group group1 = new Group
		{
			GroupName = "MATHEMATHICS GROUP",
		};
		group1.AddStudent(ref student1);
		group1.AddStudent(ref student2);

		Group group2 = new Group
		{
			GroupName = "HISTORY GROUP",
		};
		group2.AddStudent(ref student3);
		group2.AddStudent(ref student4);

		Teacher teacher1 = new Teacher
		{
			TeacherName = "Elvin Camalzade",
			TeacherExperience = "4 years",
		};
		teacher1.AddGroup(ref group1);

		Teacher teacher2 = new Teacher
		{
			TeacherName = "Tural Novruzov",
			TeacherExperience = "3 years",
		};
		teacher2.AddGroup(ref group2);

		School school = new School
		{
			Name = "SCHOOL",
		};
		school.AddTeacher(ref teacher1);
		school.AddTeacher(ref teacher2);
		
		Console.WriteLine();

		int choice = Convert.ToInt32(GetSelect("\t\tWelcome to School...\n\nPlease, enter your selection\n", new string[] { "SCHOOL INFORMATION", "EXAMS", "EXIT" }) + 1);

		if (choice == 1)
		{
			Console.Clear();
			school.ShowSchool();
		}
		else if (choice == 2)
		{
			Console.Clear();
			teacher1.StartExam("Mathemathics", "MATHEMATHICS");
			teacher2.StartExam("History", "HISTORY");
			teacher1.StartExam("Chemistry", "CHEMISTRY");
		}
		else if (choice == 3)
			Environment.Exit(0);	
	}
}