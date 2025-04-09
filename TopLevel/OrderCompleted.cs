namespace TopLevelPatternMatching
{
    internal class OrderCompleted
    {
        public int Amount { get; internal set; }
        public string PaymentType { get; internal set; }
        public bool IsInternational { get; internal set; }
    }
}