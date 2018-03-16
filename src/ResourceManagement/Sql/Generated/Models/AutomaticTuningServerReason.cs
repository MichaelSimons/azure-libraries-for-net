// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AutomaticTuningServerReason.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutomaticTuningServerReason
    {
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "Disabled")]
        Disabled,
        [EnumMember(Value = "AutoConfigured")]
        AutoConfigured
    }
    internal static class AutomaticTuningServerReasonEnumExtension
    {
        internal static string ToSerializedValue(this AutomaticTuningServerReason? value)
        {
            return value == null ? null : ((AutomaticTuningServerReason)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AutomaticTuningServerReason value)
        {
            switch( value )
            {
                case AutomaticTuningServerReason.Default:
                    return "Default";
                case AutomaticTuningServerReason.Disabled:
                    return "Disabled";
                case AutomaticTuningServerReason.AutoConfigured:
                    return "AutoConfigured";
            }
            return null;
        }

        internal static AutomaticTuningServerReason? ParseAutomaticTuningServerReason(this string value)
        {
            switch( value )
            {
                case "Default":
                    return AutomaticTuningServerReason.Default;
                case "Disabled":
                    return AutomaticTuningServerReason.Disabled;
                case "AutoConfigured":
                    return AutomaticTuningServerReason.AutoConfigured;
            }
            return null;
        }
    }
}