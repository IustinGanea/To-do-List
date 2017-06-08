using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A_3a_oara_e_cu_noroc.Model
{
    public class UserPw
    {

        [Key]
        public int UserID { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string parola { get; set; }

        public UserPw(int id,string numeuser,string p)
        {
            this.UserID = id;
            this.username = numeuser;
            this.parola = p;
        }
        public UserPw(string numeuser, string p)
        {
            
            this.username = numeuser;
            this.parola = p;
        }
        public UserPw()
        {

            this.username = "numeuser";
            this.parola = "p";
        }
    }


}
