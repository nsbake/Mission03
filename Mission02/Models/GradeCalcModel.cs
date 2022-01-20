using System;
using System.ComponentModel.DataAnnotations;

namespace Mission02.Models
{
    public class GradeCalcModel
    {
        [Range(0, 100)]
        public byte Assign { get; set; }
        [Range(0, 100)]
        public byte Group { get; set; }
        [Range(0, 100)]
        public byte Quiz { get; set; }
        [Range(0, 100)]
        public byte Exam { get; set; }
        [Range(0, 100)]
        public byte Intex { get; set; }

        public double Final { get; set; }
    }
}
