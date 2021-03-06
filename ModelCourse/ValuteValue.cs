using System;
using System.ComponentModel.DataAnnotations;

namespace ModelCourse
{
    public class ValuteValue
    {
        [Key]
        public Guid ValuteValueId { get; set; }
        public string ID { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double Previous { get; set; }
    }
}
