using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollettaDizionario
{
    public class Persona : IEquatable<Persona>
    {

        public Persona(string id, string cognome, string nome)
        {
            Id = id;
            Cognome = cognome;
            Nome = nome;
        }

        public string Id { get; set; }

        public string Cognome { get; set; }

        public string Nome { get; set; }

        public bool Equals(Persona p)
        {
            if (p == null)
                return false;
            if (p == this)
                return true;
            return Id.Equals(p.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(Object o)
        {
            if (!(o is Persona))
                return false;

            return Equals((Persona)o);
        }

        public override string ToString()
        {
            return Id + " " + Cognome + " " + Nome;
        }

    }
}
