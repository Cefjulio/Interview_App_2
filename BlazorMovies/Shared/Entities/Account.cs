using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorMovies.Shared.Entities
{
    public class Account
    {
        
        public int Id { get; set; }

        [Required (ErrorMessage="Please, Enter an Account Name")  ]
        public string Name { get; set; }

    }
}