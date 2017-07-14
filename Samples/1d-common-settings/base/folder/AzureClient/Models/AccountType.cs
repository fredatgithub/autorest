// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AwesomeNamespace.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AccountType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccountType
    {
        [EnumMember(Value = "Standard_LRS")]
        StandardLRS,
        [EnumMember(Value = "Standard_ZRS")]
        StandardZRS,
        [EnumMember(Value = "Standard_GRS")]
        StandardGRS,
        [EnumMember(Value = "Standard_RAGRS")]
        StandardRAGRS,
        [EnumMember(Value = "Premium_LRS")]
        PremiumLRS
    }
    internal static class AccountTypeEnumExtension
    {
        internal static string ToSerializedValue(this AccountType? value)  =>
            value == null ? null : ((AccountType)value).ToSerializedValue();

        internal static string ToSerializedValue(this AccountType value)
        {
            switch( value )
            {
                case AccountType.StandardLRS:
                    return "Standard_LRS";
                case AccountType.StandardZRS:
                    return "Standard_ZRS";
                case AccountType.StandardGRS:
                    return "Standard_GRS";
                case AccountType.StandardRAGRS:
                    return "Standard_RAGRS";
                case AccountType.PremiumLRS:
                    return "Premium_LRS";
            }
            return null;
        }

        internal static AccountType? ParseAccountType(this string value)
        {
            switch( value )
            {
                case "Standard_LRS":
                    return AccountType.StandardLRS;
                case "Standard_ZRS":
                    return AccountType.StandardZRS;
                case "Standard_GRS":
                    return AccountType.StandardGRS;
                case "Standard_RAGRS":
                    return AccountType.StandardRAGRS;
                case "Premium_LRS":
                    return AccountType.PremiumLRS;
            }
            return null;
        }
    }
}
