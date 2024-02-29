using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThucHanh1
{
    public class Student : Person
    {
        public Student(string name, string sex, string address, string govermentID, DateTime birthdate, string phoneNumber, string email, string ID) : base(name, sex, address, govermentID, birthdate, phoneNumber,email, ID)
        {
        }
    }
}
