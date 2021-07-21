// <copyright file="RegisterRequest.cs" company="APIMatic">
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
    /// RegisterRequest.
    /// </summary>
    public class RegisterRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRequest"/> class.
        /// </summary>
        public RegisterRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterRequest"/> class.
        /// </summary>
        /// <param name="firstName">first_name.</param>
        /// <param name="lastName">last_name.</param>
        /// <param name="email">email.</param>
        /// <param name="address1">address1.</param>
        /// <param name="address2">address2.</param>
        /// <param name="country">country.</param>
        /// <param name="state">state.</param>
        /// <param name="city">city.</param>
        public RegisterRequest(
            string firstName,
            string lastName,
            string email,
            string address1,
            string address2,
            string country,
            string state,
            string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Address1 = address1;
            this.Address2 = address2;
            this.Country = country;
            this.State = state;
            this.City = city;
        }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets Address1.
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets Address2.
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets Country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegisterRequest : ({string.Join(", ", toStringOutput)})";
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

            return obj is RegisterRequest other &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Address1 == null && other.Address1 == null) || (this.Address1?.Equals(other.Address1) == true)) &&
                ((this.Address2 == null && other.Address2 == null) || (this.Address2?.Equals(other.Address2) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -735560237;

            if (this.FirstName != null)
            {
               hashCode += this.FirstName.GetHashCode();
            }

            if (this.LastName != null)
            {
               hashCode += this.LastName.GetHashCode();
            }

            if (this.Email != null)
            {
               hashCode += this.Email.GetHashCode();
            }

            if (this.Address1 != null)
            {
               hashCode += this.Address1.GetHashCode();
            }

            if (this.Address2 != null)
            {
               hashCode += this.Address2.GetHashCode();
            }

            if (this.Country != null)
            {
               hashCode += this.Country.GetHashCode();
            }

            if (this.State != null)
            {
               hashCode += this.State.GetHashCode();
            }

            if (this.City != null)
            {
               hashCode += this.City.GetHashCode();
            }

            return hashCode;
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName == string.Empty ? "" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName == string.Empty ? "" : this.LastName)}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email == string.Empty ? "" : this.Email)}");
            toStringOutput.Add($"this.Address1 = {(this.Address1 == null ? "null" : this.Address1 == string.Empty ? "" : this.Address1)}");
            toStringOutput.Add($"this.Address2 = {(this.Address2 == null ? "null" : this.Address2 == string.Empty ? "" : this.Address2)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country == string.Empty ? "" : this.Country)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City == string.Empty ? "" : this.City)}");
        }
    }
}