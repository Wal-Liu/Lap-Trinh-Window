using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.CodeDom;


namespace BaiThucHanh1
{
    public class Person
    {
        public string name { get; set; }
        public string sex;
        public string address;
        public string grovermentID;
        public DateTime birthdate;
        public string phoneNumber;
        public string email;
        public string id;
        public Person()
        {
        }

        public Person(string name, string sex, string address, string grovermentID, DateTime birthdate, string phoneNumber, string email, string id="")
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.address = address;
            this.grovermentID = grovermentID;
            this.birthdate = birthdate;
            this.phoneNumber = phoneNumber;
            this.email = email;
            Valid();
        }
        private bool isEmpty(string input)
        {
            string tempStr = input.Trim();
            return string.IsNullOrEmpty(tempStr);
        }
        public void CheckEmpty()
        {
            PropertyInfo[] properties = typeof(Person).GetProperties();

            foreach (var property in properties)
            {
                if (property.Name != "id")
                {
                    if (isEmpty(property.GetValue(this).ToString()))
                    {
                        throw new Exception(property.Name + " is empty");
                    }
                }
            }
        }
        public void Valid()
        {
            CheckEmpty();

            if (getAge() < 17)
            {
                throw new Exception("your age must be >= 17!");
            }
            if (!IsValidPhoneNumber())
            {
                throw new Exception("This number phone isn't valid!");
            }
            if (!IsValidEmail())
            {
                throw new Exception("your email isn't valid format");
            }
        }
        private bool IsValidPhoneNumber()
        {
            string regex = @"^\(?([0-9]{3})\)?[-]([0-9]{4})[-]([0-9]{3})$";
            return Regex.IsMatch(phoneNumber, regex);
        }

        private bool IsValidEmail()
        {
            string regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(email, regex);
        }
        public int getAge()
        {
            int age = (int)Math.Floor((DateTime.Now - birthdate).TotalDays / 365.25D);
            return age;
        }
    }

}
