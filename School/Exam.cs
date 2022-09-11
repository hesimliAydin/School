class Exam
{
	public string? Lesson { get; set; }
	public int Score { get; set; }
	public DateTime ExamTime { get; set; }
	public void ShowExam()
	{
		Console.WriteLine("\n\n========== EXAM ============\n");
		Console.WriteLine($"Lesson : {Lesson}");
		
		if (Score > 90)
			Console.WriteLine($"Score : {Score} A => (Excellent)");
		else if (Score > 80)
			Console.WriteLine($"Score : {Score} B => (Very Good)");
		else if (Score > 70)
			Console.WriteLine($"Score : {Score} C => (Good)");
		else if (Score > 60)
			Console.WriteLine($"Score : {Score} D => (Enough)");
		else if (Score > 50)
			Console.WriteLine($"Score : {Score} E => (Insufficient)");
		else if (Score > 0)
		{
			Console.WriteLine($"Score : {Score} F => (Failed)");
			Console.WriteLine("\nSorry, You failed the exam !");
			Console.ResetColor();
		}
		else
			throw new Exception("Score Cannot Negative Number !");
		
		Console.WriteLine($"Exam Time : {ExamTime}");
		Console.WriteLine();
		Console.ResetColor();
	}
}