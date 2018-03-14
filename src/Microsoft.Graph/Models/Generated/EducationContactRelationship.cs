// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum EducationContactRelationship.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum EducationContactRelationship
    {
    
        /// <summary>
        /// parent
        /// </summary>
        Parent = 0,
	
        /// <summary>
        /// relative
        /// </summary>
        Relative = 1,
	
        /// <summary>
        /// aide
        /// </summary>
        Aide = 2,
	
        /// <summary>
        /// doctor
        /// </summary>
        Doctor = 3,
	
        /// <summary>
        /// guardian
        /// </summary>
        Guardian = 4,
	
        /// <summary>
        /// child
        /// </summary>
        Child = 5,
	
        /// <summary>
        /// other
        /// </summary>
        Other = 6,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 7,
	
    }
}