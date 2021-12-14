namespace Edudocs.Common.Models
{
    /// <summary>
    /// Information about specific document in file system
    /// </summary>
    public sealed class DocumentInfo
    {
        public string FileName { get; set; }
        public DateTime CreatedDataTime { get; set; }
        public DateTime UpdatedDataTime { get; set; }
    }
}
