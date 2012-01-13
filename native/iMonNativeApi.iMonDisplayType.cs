namespace iMon.DisplayApi
{
    public static partial class iMonNativeApi
    {
        /// <summary>
        /// These enumeration values represent display type.
        /// Currently iMON Display API supports VFD and LCD products.
        /// </summary>
        public enum iMonDisplayType
        {
            None = 0,
            /// <summary>
            /// VFD product
            /// </summary>
            VFD = 0x01,
            /// <summary>
            /// LCD product
            /// </summary>
            LCD = 0x02,
        }
    }
}