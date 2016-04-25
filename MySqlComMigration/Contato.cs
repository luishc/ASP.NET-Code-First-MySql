using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MySqlComMigration
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public static List<Contato> Listar()
        {
            using (Contexto contexto = new Contexto())
            {
                return contexto.Contato.ToList();
            }
        }
    }
}