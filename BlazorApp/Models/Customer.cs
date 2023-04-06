
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Customer
    {
        public Customer()
        {

        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O Email é inválido.")]
        public string Email { get; set; }

        public void New()
        {
            Id = Guid.NewGuid();
        }

        public void Save(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
