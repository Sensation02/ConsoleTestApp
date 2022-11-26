using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppBL.Model
{
    internal class User
    {
        public string Name { get; }
        public Gender Gender { get; }
        public DataType BirthDate { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("User name can't be empty or null", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Gender name can't be null", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900") && birthDate >= DateTime.Now)
            {
                
            }
            if (weight <= 0.0)
            {

            }
            if (height <= 0.0)
            {

            }
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
    }
}
