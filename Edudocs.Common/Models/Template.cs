using Edudocs.Common.Options;

namespace Edudocs.Common.Models
{
    /// <summary>
    /// Represents specific template
    /// </summary>
    public sealed class Template
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DocumentInfo FileInfo { get; set; }
        public string? Description { get; set; }
        public DegreeOptions Degrees { get; set; }
        public DateTime UploadedDataTime { get; set; }
        public List<Field>? Fields { get; set; }
    }
}
