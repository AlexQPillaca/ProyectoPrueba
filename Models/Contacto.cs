using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pruebitaa.Models
{
  
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int Id { get; set; }

       
        public string Name {get;set;}

        
        public string Email {get;set;}
        
        public string Subject {get; set; } 
        
        public string Comment {get; set; }
    }
        
}
