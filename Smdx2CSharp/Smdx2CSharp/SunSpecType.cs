using System;
using System.Numerics;

// ReSharper disable BuiltInTypeReferenceStyle

namespace Smdx2CSharp
{
    public static class SunSpecType
    {
        
        public static Type ToSystemType(string? sunSpecType)
        {
            switch (sunSpecType)
            {
                case "int16":
                case "sunssf":
                case "sf":
                    return typeof(Int16);
                case "uint16":
                case "raw16":
                case "acc16":
                case "enum16":
                case "bitfield16":
                case "count":
                case "pad":
                    return typeof(UInt16);
                case "int32":
                    return typeof(Int32);
                case "uint32":
                case "acc32":
                case "enum32":
                case "bitfield32":
                case "ipaddr":
                    return typeof(UInt32);
                case "int64":
                    return typeof(Int64);
                case "uint64":
                case "acc64":
                case "eui48":    // 48-bit MAC address
                case "bitfield64":
                    return typeof(UInt64);
                case "ipv6addr":    // 16-byte IP V6 address
                    return typeof(BigInteger);
                case "float32":
                    return typeof(float);
                case "float64":
                    return typeof(double);
                case "string":    // String (Latin-3 encoded)
                    return typeof(string);
                default:
                    throw new ArgumentException($"Unknown SunSpec Type '{sunSpecType}'");
            }
        }
        
    }
}
