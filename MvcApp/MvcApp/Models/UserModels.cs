using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApp.Models
{
    public class UserModels
    {
        [DisplayName("First Name")]
        [Required (ErrorMessage="First name is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required]
        [StringLength (50)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Range (100,1000000)]
        public decimal Salary { get; set; }
    }
    public class Users
    {
        public List<UserModels> _userList = new List<UserModels>();
        public Users()
        {
            _userList.Add(new UserModels
            {
                FirstName = "Anuja",
                LastName = "Pawar",
                Address = "Indore MP",
                Email = "test@test.com",
                DOB = Convert.ToDateTime("6/22/1976"),
                Salary = 40000
            });
            _userList.Add(new UserModels
            {
                FirstName = "Deerghika",
                LastName = "Pawar",
                Address = "Indore MP",
                Email = "test1@test.com",
                DOB = Convert.ToDateTime("7/11/2001"),
                Salary = 7000
            });
            _userList.Add(new UserModels
            {
                FirstName = "Arnav",
                LastName = "Pawar",
                Address = "Indore MP",
                Email = "test2@test.com",
                DOB = Convert.ToDateTime("3/12/2010"),
                Salary = 5000
            });
        }
        public void CreateUser(UserModels userModel)
        {
            _userList.Add(userModel);
        }
        public void UpdateUser(UserModels userModel)
        {
            foreach(UserModels usrlst in _userList)
            {
                if (usrlst.Email == userModel.Email)
                {
                    _userList.Remove(usrlst);
                    _userList.Add(userModel);
                    break;
                }
            }
        }

        internal void CreateUser(object userModel)
        {
            throw new NotImplementedException();
        }
    }
}
