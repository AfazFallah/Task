using AIPFramework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Domain.User.Entities
{
    public class User : Entity<int>
    {
        #region Data Annotations
        [Display(Name = "نام")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "{0} باید بین {1} تا {2} کاراکتر باشد")]
        [Required(ErrorMessage = "{0} اجباری است")]
        #endregion
        public string Name { get; private set; }

        #region Data Annotations
        [Display(Name = "نام خانوادگی")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "{0} باید بین {1} تا {2} کاراکتر باشد")]
        [Required(ErrorMessage = "{0} اجباری است")]
        #endregion
        public string Family { get;private set; }

        #region Data Annotations
        [Required(ErrorMessage = "{0} اجباری است")]
        #endregion
        public int Age { get; private set; }
        public User(){}
        public User(string name, string family, int age)
        {
            Name = name;
            Family = family;
            Age = age;
        }
        public void ChangeName(string name)
        {
            Name = name;
        }
        public void ChangeFamily(string family)
        {
            Family = family;
        }
        public void ChangeAge(int age)
        {   
            Age = age;
        }
        public static User Create(string name, string family, int age)
        {
            return new User(name , family , age);
        }
    }
}
