using Edudocs.Common.Options;

namespace Edudocs.Common.Models
{
    /// <summary>
    /// Represents educational program
    /// </summary>
    public sealed class EducationalProgram
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public DegreeOptions Degrees { get; set; }
    }
}
