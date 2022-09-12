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
			Name = "Isa",
			Surname = "Memmedli",
			Age = 20,
			Exam = exam1
		};

		Student student4 = new Student
		{
			ID = Guid.NewGuid(),
			Name = "Emin",
			Surname = "Novruz",
			Age = 23,
			Exam = exam2
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
		group2.AddStudent(ref student1);
		group2.AddStudent(ref student2);

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

		int choice = Convert.ToInt32(GetSelect("\t\tWelcome to School...\n\nPlease, enter your selection\n", new string[] { "EXAMS", "SCHOOL INFORMATION", "CREATE STUDENT", "EXIT" }) + 1);

		if (choice == 1)
		{
			Console.Clear();
			school.ShowSchool();
		}
		else if (choice == 2)
		{
			Console.Clear();
			int select = Convert.ToInt32(GetSelect("\n\nSelect any group\n\n", new string[] { "MATHEMATHICS GROUP", "HISTORY GROUP", "EXIT" }) + 1);

			if (select == 1)
			{
				Console.Clear();
				teacher1.ShowTeacher();
				Thread.Sleep(1500);
				student1.ShowStudent();
				student2.ShowStudent();
			}
			else if (select == 2)
			{
				Console.Clear();
				teacher2.ShowTeacher();
				Thread.Sleep(1500);
				student3.ShowStudent();
				student4.ShowStudent();
			}
			else if (select == 3)
				Environment.Exit(0);
		}
		else if (choice == 3)
        {
            Console.Write("Enter name : ");
			string? name = Console.ReadLine();
			Console.Write("Enter surname : ");
			string? surname = Console.ReadLine();
			
			Student student5 = new Student
			{
				Name = name,
				Surname = surname,
				Age = 23
			};

			group1.AddStudent(ref student5);
		}
		else if (choice == 4)
			Environment.Exit(0);	
	}
}