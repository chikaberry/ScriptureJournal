using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyScriptureJournal.Cannon
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Notes { get; set; }

    }
}
