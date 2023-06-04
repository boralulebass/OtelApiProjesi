using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Service
{
    public class UpdateServiceDto
    {
        [Required]
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet ikon linki giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir.")]
        public string ServiceTitle { get; set; }
        public string ServiceDesc { get; set; }
    }
}
