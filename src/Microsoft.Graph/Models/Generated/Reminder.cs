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
    /// The type Reminder.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Reminder
    {

        /// <summary>
        /// Gets or sets eventId.
        /// The unique ID of the event. Read only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventId", Required = Newtonsoft.Json.Required.Default)]
        public string EventId { get; set; }
    
        /// <summary>
        /// Gets or sets eventStartTime.
        /// The date, time, and time zone that the event starts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventStartTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone EventStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets eventEndTime.
        /// The date, time and time zone that the event ends.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventEndTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone EventEndTime { get; set; }
    
        /// <summary>
        /// Gets or sets changeKey.
        /// Identifies the version of the reminder. Every time the reminder is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "changeKey", Required = Newtonsoft.Json.Required.Default)]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets eventSubject.
        /// The text of the event's subject line.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventSubject", Required = Newtonsoft.Json.Required.Default)]
        public string EventSubject { get; set; }
    
        /// <summary>
        /// Gets or sets eventLocation.
        /// The location of the event.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventLocation", Required = Newtonsoft.Json.Required.Default)]
        public Location EventLocation { get; set; }
    
        /// <summary>
        /// Gets or sets eventWebLink.
        /// The URL to open the event in Outlook on the web.The event will open in the browser if you are logged in to your mailbox via Outlook on the web. You will be prompted to login if you are not already logged in with the browser.This URL can be accessed from within an iFrame.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eventWebLink", Required = Newtonsoft.Json.Required.Default)]
        public string EventWebLink { get; set; }
    
        /// <summary>
        /// Gets or sets reminderFireTime.
        /// The date, time, and time zone that the reminder is set to occur.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reminderFireTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeTimeZone ReminderFireTime { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
