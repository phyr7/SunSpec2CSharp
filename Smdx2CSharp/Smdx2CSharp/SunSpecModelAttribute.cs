using System;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Smdx2CSharp
{
    // ReSharper disable once UnusedType.Global
    public class SunSpecModelAttribute : Attribute
    {
        /// <summary>
        /// SunSpec Model ID
        /// </summary>
        public long Id { get; }
        
        /// <summary>
        /// Length of Data Block
        /// </summary>
        public long Length { get; }

        public SunSpecModelAttribute(long id, long length)
        {
            Id = id;
            Length = length;
        }
    }
}