using Edudocs.Common.Options;

namespace Edudocs.Common.Models
{
    /// <summary>
    /// Represents field of template
    /// </summary>
    public sealed class Field
    {
        public string MarkName { get; set; }
        public string DisplayName { get; set; }
        public string? Description { get; set; }
        public InputTypeOption InputType { get; set; }
        public bool IsRequired { get; set; }
    }
}
