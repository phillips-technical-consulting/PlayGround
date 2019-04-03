
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace PlayGround.Models
{
    public class User
    {


        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitialTxt { get; set; }
        public string LoginIdTxt { get; set; }
        public string PasswordTxt { get; set; }
        public string EmailTxt { get; set; }
        public bool EnabledInd { get; set; }
        public string PhoneNumberTxt { get; set; }
        

    }
}


