namespace TerraSharp.Client.Lcd
{
    public class PaginationOptions
    {
        private string paginationLimit { get; set; }
        private string paginationOffset { get; set; }
        private string paginationKey { get; set; }
        private bool paginationCountTotal { get; set; }
        private bool paginationReverse { get; set; }

        public PaginationOptions(string limit, string offset, string key, bool countTotal, bool reverse)
        {
            paginationLimit = limit;
            paginationOffset = offset;
            paginationKey = key;
            paginationCountTotal = countTotal;
            paginationReverse = reverse;
        }

        public string getPaginationLimit() => paginationLimit;
        public string getPaginationOffset() => paginationOffset;
        public string getPaginationKey() => paginationKey;
        public bool getPaginationCountTotal() => paginationCountTotal;
        public bool getPaginationReverse() => paginationReverse;
    }
}
