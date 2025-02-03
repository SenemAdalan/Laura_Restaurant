using System.ComponentModel.DataAnnotations;

namespace Cafe.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public int Sayi { get; set; }
        public string Saat { get; set; }
        public DateTime Tarih { get; set; }
    }
}
