namespace Liskkov_Substitution_Principle
{
    public class Program
    {
        // nếu s là 1 loại phụ của t thì đối tượng ở dạng t có thể
        // được đặt ở dạng s mà không làm hỏng chương trình
        // ví dụ ở chương trình này employee thay bằng manager hay CEO ở chỗ new object()
        public static void Main(string[] args)
        {
            Manager accountingVp = new Manager();
            accountingVp.FirstName = "Lieu";
            accountingVp.LastName = "Oanh";
            accountingVp.CalculatePerHourRate(4);

            BaseEmployee emp = new CEO();

            emp.FirstName = "Duc";
            emp.LastName = "Manh";
            //emp.AssignManager(accountingVp);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}{emp.LastName}'s salary is {emp.Salary}/hour");

            Console.ReadLine();
        }
    }
}