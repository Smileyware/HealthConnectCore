using System;
using System.Collections.Generic;

namespace HealthConnect.Accessor.healthconnectdb
{
    public partial class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; }
        public string ExpectedResponse { get; set; }
        public int? IsParent { get; set; }
        public string Parent { get; set; }
        public int? IsChild { get; set; }
        public string CreatedDate { get; set; }
        public int? InstaFail { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int? IsDeleted { get; set; }
    }
}
