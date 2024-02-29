using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    internal class TeacherDAO : PersonDAO
    {
        public TeacherDAO() : base (objName : "Teacher")
        { }
    }
}
