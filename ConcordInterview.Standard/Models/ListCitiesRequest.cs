// <copyright file="ListCitiesRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ConcordInterview.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ConcordInterview.Standard;
    using ConcordInterview.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ListCitiesRequest.
    /// </summary>
    public class ListCitiesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCitiesRequest"/> class.
        /// </summary>
        public ListCitiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCitiesRequest"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        /// <param name="stateCode">state_code.</param>
        public ListCitiesRequest(
            string countryCode,
            string stateCode)
        {
            this.CountryCode = countryCode;
            this.StateCode = stateCode;
        }

        /// <summary>
        /// Gets or sets CountryCode.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets StateCode.
        /// </summary>
        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListCitiesRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is ListCitiesRequest other &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.StateCode == null && other.StateCode == null) || (this.StateCode?.Equals(other.StateCode) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 439346961;

            if (this.CountryCode != null)
            {
               hashCode += this.CountryCode.GetHashCode();
            }

            if (this.StateCode != null)
            {
               hashCode += this.StateCode.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode == string.Empty ? "" : this.CountryCode)}");
            toStringOutput.Add($"this.StateCode = {(this.StateCode == null ? "null" : this.StateCode == string.Empty ? "" : this.StateCode)}");
        }
    }
}