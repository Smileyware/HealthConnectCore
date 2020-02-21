using System;
using System.Collections.Generic;

namespace HealthConnect.Accessor.healthconnectdb
{
    public partial class Answer
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public int? UserId { get; set; }
        public string Response { get; set; }
        public string CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
