﻿namespace Back_End.Data
{
    public class Dose
    {
        public int Id { get; set; }
        public string Medicament { get; set; }
        public string Dosage { get; set; }

        public string ? IdUtilisateur {  get; set; }
        public  Utilisateur Utilisateur { get; set; }
    }
}
