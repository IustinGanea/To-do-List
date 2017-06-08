using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A_3a_oara_e_cu_noroc.Model
{
    public class InitDB
    {
        public static void Initialize(OurDbContext _context)
        {
            foreach (var user in _context.UseriParole)
                _context.UseriParole.Remove(user);
            _context.SaveChanges();
            foreach (var user in _context.ElementeLista)
                _context.ElementeLista.Remove(user);
            _context.SaveChanges();
            if (_context.ElementeLista.Any())
            {
                return;
            }
            DateTime dt1 = new DateTime(2017, 6, 8);
            DateTime dt2 = new DateTime(2017, 6, 9);
            


            UserPw eu = new UserPw("Iustin", "parola");
            UserPw tania = new UserPw("Tania", "parola");
            Iteme rufe = new Iteme(
                "Strange rufele",
                "Nu uita sa iei rufele de pe sarma,sa le calci si sa le pui la loc",
                false,
                dt1);
            Iteme cos = new Iteme(
                "Du cosul de gunoi",
                "Nu uita sa duci gunoiul si sa pui alt sac in cosul de gunoi",
                false,
                dt2);

            _context.UseriParole.Add(eu);
            _context.UseriParole.Add(tania);
            _context.ElementeLista.Add(rufe);
            _context.ElementeLista.Add(cos);
            _context.SaveChanges();
        }
    }
}
