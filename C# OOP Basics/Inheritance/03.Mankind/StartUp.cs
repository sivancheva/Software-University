using System;

public class StartUp
{
    static void Main(string[] args)
    {
        try
        {
            var studentInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var workerInput = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Student student = new Student(studentInput[0], studentInput[1], studentInput[2]);
            Worker worker = new Worker(workerInput[0], workerInput[1], decimal.Parse(workerInput[2]), decimal.Parse(workerInput[3]));

            Console.WriteLine(student.ToString());
            Console.WriteLine(worker.ToString());

        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
}

