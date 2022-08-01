namespace Open_Close_Principle
{
    public class Program
    {
        // class nên đóng để sửa đổi và mở để mở rộng
        // hiểu là nó chạy ngon rồi thì k động vào nó nữa, tạo ra 1 em khác
        // kế thừa nó là mở rộng em khác. thì những cái chạy ở code cũ sẽ không
        // bị ảnh hưởng nữa
        // lưu ý : trong trường hợp đang phát triển thì thay đổi vi phạm OCP được
        // còn trong trường hợp thành production rồi thì sửa là vi phạm, hoặc
        // ít nhất chỉ sửa khi có bug thôi
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel{ FirstName = "Mạnh", LastName = "TôNguyễnĐức"},
                new ManagerModel{ FirstName = "Oanh", LastName = "LiễuThị"},
                new ExecutiveModel{ FirstName = "Nam", LastName = "HảiNguyễn"}
            };
            List<EmployeeModel> employees = new List<EmployeeModel>();
            
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} : {emp.EmailAddress} IsManager: { emp.IsManager} IsExecutive: {emp.IsExecutive}");
            }
            Console.ReadLine();
        }
    }
}