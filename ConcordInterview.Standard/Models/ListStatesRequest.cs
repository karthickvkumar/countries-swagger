// <copyright file="ListStatesRequest.cs" company="APIMatic">
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
    /// ListStatesRequest.
    /// </summary>
    public class ListStatesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListStatesRequest"/> class.
        /// </summary>
        public ListStatesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListStatesRequest"/> class.
        /// </summary>
        /// <param name="countryCode">country_code.</param>
        public ListStatesRequest(
            string countryCode)
        {
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Gets or sets CountryCode.
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListStatesRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is ListStatesRequest other &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -58094274;

            if (this.CountryCode != null)
            {
               hashCode += this.CountryCode.GetHashCode();
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
        }
    }
}