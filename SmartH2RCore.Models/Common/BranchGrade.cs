namespace SmartH2RCore.Models.Common
{
    public class BranchGrade
    {
        public virtual Branch Branch { get; set; }
        public int BranchId { get; set; }
        public int GradeId { get; set; }
        public virtual Grade Grade { get; set; }
    }
}
