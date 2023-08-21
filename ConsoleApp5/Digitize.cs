namespace ConsoleApp5
{
    public struct Digitize
    {
        private long _bit;

        public Digitize(long bit)
        {
            _bit = bit;
        }


        public string Bit
            => $"{(_bit / bitINBit):N0} _bit";

        public string Byte
            => $"{(_bit / bitINByte):N0} Byte";

        public string KB
            => $"{(_bit / bitINKB):N0} KB";

        public string MB
            => $"{(_bit / bitINMB):N0} MB";

        public string GB
            => $"{(_bit / bitINGB):N0} GB";

        public string TB
            => $"{(_bit / bitINTB):N0} TB";


        private const long bitINBit = 1;
        private const long bitINByte = 8;
        private const long bitINKB = bitINByte * 1024;
        private const long bitINMB = bitINKB * 1024;
        private const long bitINGB = bitINMB * 1024;
        private const long bitINTB = bitINGB * 1024;


    }
}