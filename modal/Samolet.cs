using System.ComponentModel.DataAnnotations;

namespace Practica1.modal
{
    public class Samolet
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите имя пользователя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите адрес электронной почты")]
        public string Type { get; set; }
        public string Model { get; set; }
        public Samolet()
        {
            Name ??= string.Empty;
            Type ??= string.Empty;
            Model ??= string.Empty;
        }
    }
}
