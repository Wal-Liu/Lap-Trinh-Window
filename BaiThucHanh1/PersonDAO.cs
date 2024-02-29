using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh1
{
    internal class PersonDAO
    {
        private string objName;

        public string ObjName
        {
            get { return objName; }
            set { objName = value;  }
        }
        public DBConnection DBConnection 
        {
            get { return dBConnection ; }
            set { dBConnection = value; }
        }
        public PersonDAO(string objName)
        {
            ObjName = objName;
        }

        DBConnection dBConnection = new DBConnection(Properties.Settings.Default.connStr);

        public DataTable Load()
        {
            return DBConnection.LoadDataFromTable(ObjName);
        }

        public void Add(Person person)
        {
            string sqlStr = string.Format($"INSERT INTO {ObjName}(name,sex, address, gorvementID, birthdate,phoneNumber, email VALUE ('{person.name}', '{person.sex}', '{person.address}', '{person.grovermentID}', '{person.birthdate}', '{person.phoneNumber}', '{person.email}')");
            dBConnection.QueryCommand(sqlStr);
        }

        public void Delete(string id)
        {
            string sqlStr = $"DELETE FROM {ObjName} WHERE id = '{id}'";
            dBConnection.QueryCommand(sqlStr);
        }

        public void Edit (Person person)
        {
            string sqlStr = string.Format($"UPDATE {ObjName} SET name = '{person.name}', sex = '{person.sex}', address = '{person.address}', governmentID = '{person.grovermentID}' , birthdate = '{person.birthdate.ToString()}', phoneNumber = '{person.phoneNumber}', email = '{person.email}' WHERE id = {person.id}");
            dBConnection.QueryCommand(sqlStr);
        }
}
}
