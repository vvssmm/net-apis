namespace NET.Apis.Domain.Pos
{
    public class PosHandleQRResult
    {
        public bool IsSuccess { get; set; }
        public IList<string> Messages { get; set; }
    }
}
