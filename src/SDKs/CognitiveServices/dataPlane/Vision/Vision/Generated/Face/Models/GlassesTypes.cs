// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for GlassesTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GlassesTypes
    {
        [EnumMember(Value = "noGlasses")]
        NoGlasses,
        [EnumMember(Value = "readingGlasses")]
        ReadingGlasses,
        [EnumMember(Value = "sunglasses")]
        Sunglasses,
        [EnumMember(Value = "swimmingGoggles")]
        SwimmingGoggles
    }
    internal static class GlassesTypesEnumExtension
    {
        internal static string ToSerializedValue(this GlassesTypes? value)
        {
            return value == null ? null : ((GlassesTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this GlassesTypes value)
        {
            switch( value )
            {
                case GlassesTypes.NoGlasses:
                    return "noGlasses";
                case GlassesTypes.ReadingGlasses:
                    return "readingGlasses";
                case GlassesTypes.Sunglasses:
                    return "sunglasses";
                case GlassesTypes.SwimmingGoggles:
                    return "swimmingGoggles";
            }
            return null;
        }

        internal static GlassesTypes? ParseGlassesTypes(this string value)
        {
            switch( value )
            {
                case "noGlasses":
                    return GlassesTypes.NoGlasses;
                case "readingGlasses":
                    return GlassesTypes.ReadingGlasses;
                case "sunglasses":
                    return GlassesTypes.Sunglasses;
                case "swimmingGoggles":
                    return GlassesTypes.SwimmingGoggles;
            }
            return null;
        }
    }
}