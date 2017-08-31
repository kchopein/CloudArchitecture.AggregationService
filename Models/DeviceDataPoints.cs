/*
 * IoT Aggregator API
 *
 * Sample API for aggregating data from multiple IoT devices and returning stored running averages.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace AggregationService.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class DeviceDataPoints : List<InlineResponse200>,  IEquatable<DeviceDataPoints>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDataPoints" /> class.
        /// </summary>
        public DeviceDataPoints()
        {
            
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeviceDataPoints {\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((DeviceDataPoints)obj);
        }

        /// <summary>
        /// Returns true if DeviceDataPoints instances are equal
        /// </summary>
        /// <param name="other">Instance of DeviceDataPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceDataPoints other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return false;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(DeviceDataPoints left, DeviceDataPoints right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(DeviceDataPoints left, DeviceDataPoints right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}