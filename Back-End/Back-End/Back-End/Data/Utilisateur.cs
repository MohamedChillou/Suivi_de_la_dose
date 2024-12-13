using Microsoft.AspNetCore.Identity;

namespace Back_End.Data
{
    public class Utilisateur :IdentityUser
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string MotDePasse {  get; set; }
        public string Email { get; set; }
        public IList<Dose> Doses { get; set; }
    }
}
