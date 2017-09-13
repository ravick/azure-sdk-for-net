// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Performance monitor sample in a set.
    /// </summary>
    public partial class PerfMonSample
    {
        /// <summary>
        /// Initializes a new instance of the PerfMonSample class.
        /// </summary>
        public PerfMonSample()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PerfMonSample class.
        /// </summary>
        /// <param name="time">Point in time for which counter was
        /// measured.</param>
        /// <param name="instanceName">Name of the server on which the
        /// measurement is made.</param>
        /// <param name="value">Value of counter at a certain time.</param>
        /// <param name="coreCount">Core Count of worker. Not a data
        /// member</param>
        public PerfMonSample(System.DateTime? time = default(System.DateTime?), string instanceName = default(string), double? value = default(double?), int? coreCount = default(int?))
        {
            Time = time;
            InstanceName = instanceName;
            Value = value;
            CoreCount = coreCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets point in time for which counter was measured.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public System.DateTime? Time { get; set; }

        /// <summary>
        /// Gets or sets name of the server on which the measurement is made.
        /// </summary>
        [JsonProperty(PropertyName = "instanceName")]
        public string InstanceName { get; set; }

        /// <summary>
        /// Gets or sets value of counter at a certain time.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

        /// <summary>
        /// Gets or sets core Count of worker. Not a data member
        /// </summary>
        [JsonProperty(PropertyName = "coreCount")]
        public int? CoreCount { get; set; }

    }
}