using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeNG.TableFilter.Example.Infrastructure.Entities
{
    [Table(("webboard_data"))]
    public class WebBoardData
    {
        [Key]
        [Column("No")]
        public int No { get; set; }
        
        [Column("Category")]
        public string Category { get; set; }
        
        [Column("Question")]
        public string Question { get; set; }
        
        [Column("Note")]
        public string Note { get; set; }
        
        [Column("Name")]
        public string Name { get; set; }
        
        [Column("Namer")]
        public string Namer { get; set; }

        [Column("Member")]
        public int Member { get; set; }
        
        [Column("Memberr")]
        public string Memberr { get; set; }
        
        [Column("IP")]
        public string IP { get; set; }
        
        [Column("Email")]
        public string Email { get; set; }
        
        [Column("Reply")]
        public string Reply { get; set; }
        
        [Column("ReplyDate")]
        public DateTime ReplyDate { get; set; }
        
        [Column("Date")]
        public DateTime Date { get; set; }
    }
}