using MessagePack.Formatters;
using System.ComponentModel.DataAnnotations;

namespace PresProje.Models
{
    public class PRES_PROD
    {
        [Key]
        public int ID { get; set; }

        public string? URETIM_TARIH { get; set; }
        public string? HAT { get; set; }
        public string? VARDIYA { get; set; }
        public string? MESAI { get; set; }
        public string? PRES { get; set; }
        public string? IS_EMRI { get; set; }
        public string? PARCA_NO { get; set; }
        public string? OPERASYON_SAYISI { get; set; }
        public string? SURE_DK { get; set; }
        public string? OPERATOR_SAYISI { get; set; }
        public string? HATA_KODU { get; set; }
        public string? HATA_TANIMI { get; set; }
        public string? VURUS { get; set; }
        public string? PROJE_IS_EMRI { get; set; }
        public string? ACIKLAMA { get; set; }

    }
}
