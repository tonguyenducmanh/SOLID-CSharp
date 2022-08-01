using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_inversion_principle
{
    public class Program
    {
        // Nguyên tắc nghịch đảo phụ thuộc
        // module cấp cao không nên phụ thuộc vào module cấp thấp
        // cả 2 nên phụ thuộc vào phần trừu tượng (abstraction) 
        // và những phần trừ tượng đó không nên phụ thuộc vào chi tiết
        // (tức là ta tìm cách đảo ngược để module cấp thấp phụ
        // thuộc vào module cấp cao


        // ở dưới đây Main class là cấp cao phụ thuộc vào Person class và Chore class cấp thấp
        // là không nên, ngoài ra Chore cũng là cấp cao phụ thuộc vào Logger và Email class
        // không thể thay đổi mấy thằng nhỏ như Chore và Person vì nó sẽ phá vỡ Main
        public static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();

            owner.FirstName = "Manh";
            owner.LastName = "ToNguyen";
            owner.EmailAddress = "Ducmanh14032000@gmail.com";
            owner.PhoneNumber = "0981071321";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Di do rac di";
            chore.Owner = owner;


            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();
            Console.ReadLine();
        }
    }
}