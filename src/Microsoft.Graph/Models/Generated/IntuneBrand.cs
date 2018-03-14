// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IntuneBrand.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class IntuneBrand
    {
    
        /// <summary>
        /// Gets or sets displayName.
        /// Company/organization name that is displayed to end users.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets contactITName.
        /// Name of the person/organization responsible for IT support.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactITName", Required = Newtonsoft.Json.Required.Default)]
        public string ContactITName { get; set; }
    
        /// <summary>
        /// Gets or sets contactITPhoneNumber.
        /// Phone number of the person/organization responsible for IT support.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactITPhoneNumber", Required = Newtonsoft.Json.Required.Default)]
        public string ContactITPhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets contactITEmailAddress.
        /// Email address of the person/organization responsible for IT support.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactITEmailAddress", Required = Newtonsoft.Json.Required.Default)]
        public string ContactITEmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets contactITNotes.
        /// Text comments regarding the person/organization responsible for IT support.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactITNotes", Required = Newtonsoft.Json.Required.Default)]
        public string ContactITNotes { get; set; }
    
        /// <summary>
        /// Gets or sets privacyUrl.
        /// URL to the company/organization’s privacy policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "privacyUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PrivacyUrl { get; set; }
    
        /// <summary>
        /// Gets or sets onlineSupportSiteUrl.
        /// URL to the company/organization’s IT helpdesk site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineSupportSiteUrl", Required = Newtonsoft.Json.Required.Default)]
        public string OnlineSupportSiteUrl { get; set; }
    
        /// <summary>
        /// Gets or sets onlineSupportSiteName.
        /// Display name of the company/organization’s IT helpdesk site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineSupportSiteName", Required = Newtonsoft.Json.Required.Default)]
        public string OnlineSupportSiteName { get; set; }
    
        /// <summary>
        /// Gets or sets themeColor.
        /// Primary theme color used in the Company Portal applications and web portal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "themeColor", Required = Newtonsoft.Json.Required.Default)]
        public RgbColor ThemeColor { get; set; }
    
        /// <summary>
        /// Gets or sets showLogo.
        /// Boolean that represents whether the administrator-supplied logo images are shown or not shown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showLogo", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowLogo { get; set; }
    
        /// <summary>
        /// Gets or sets lightBackgroundLogo.
        /// Logo image displayed in Company Portal apps which have a light background behind the logo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lightBackgroundLogo", Required = Newtonsoft.Json.Required.Default)]
        public MimeContent LightBackgroundLogo { get; set; }
    
        /// <summary>
        /// Gets or sets darkBackgroundLogo.
        /// Logo image displayed in Company Portal apps which have a dark background behind the logo.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "darkBackgroundLogo", Required = Newtonsoft.Json.Required.Default)]
        public MimeContent DarkBackgroundLogo { get; set; }
    
        /// <summary>
        /// Gets or sets showNameNextToLogo.
        /// Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showNameNextToLogo", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowNameNextToLogo { get; set; }
    
        /// <summary>
        /// Gets or sets showDisplayNameNextToLogo.
        /// Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showDisplayNameNextToLogo", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowDisplayNameNextToLogo { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}