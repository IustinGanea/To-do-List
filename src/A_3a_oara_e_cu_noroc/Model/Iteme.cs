using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace A_3a_oara_e_cu_noroc.Model
{
    public class Iteme
    {
        [Key]
        [Required]
        public int idElement { get; set; }
        [Required]
        public string nume { get; set; }
        [Required]
        public string descriere { get; set; }
        public bool terminat { get; set; }
        public DateTime deadline { get; set; }

        public Iteme()
        {
            DateTime dt3 = new DateTime(2017, 6, 10);
            this.nume = "na";
            this.descriere = "da";
            this.terminat = false;
            this.deadline = dt3;
        }

        public Iteme(string n)
        {
            DateTime dt3 = new DateTime(2017, 6, 10);
            this.nume =n;
            this.descriere = "da";
            this.terminat = false;
            this.deadline = dt3;

        }

        public Iteme(string n,string d,bool t,DateTime a)
        {
           
            this.nume = n;
            this.descriere = d;
            this.terminat = t;
            this.deadline = a;
        }

        public Iteme(int id,string n, string d, bool t, DateTime a)
        {
            this.idElement = id;
            this.nume = n;
            this.descriere = d;
            this.terminat = t;
            this.deadline = a;
        }
        public Iteme(string n,string d )
        {
            DateTime a = new DateTime(2017, 6, 10);
            this.nume = n;
            this.descriere = d;
            this.terminat = false;
            this.deadline = a;
        }
       
    }




}
