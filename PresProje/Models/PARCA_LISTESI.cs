using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace PresProje.Models
{
    public class PARCA_LISTESI
    {
        [Key]
        public string? Malzeme { get; set; }
    }
}
