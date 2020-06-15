using System;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global

namespace phyr7.SunSpec
{
    // ReSharper disable once UnusedType.Global
    public class SunSpecPropertyAttribute : Attribute
    {
        /// <summary>
        /// Data Offset
        /// </summary>
        public long Offset { get; }
        
        /// <summary>
        /// Length given in 16bit Modbus Registers
        /// </summary>
        public long Length { get; }

        public SunSpecPropertyAttribute(long offset, long length)
        {
            Offset = offset;
            Length = length;
        }
    }
}