// <copyright file="MiscControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ConcordInterview.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Threading.Tasks;
    using ConcordInterview.Standard;
    using ConcordInterview.Standard.Controllers;
    using ConcordInterview.Standard.Exceptions;
    using ConcordInterview.Standard.Http.Client;
    using ConcordInterview.Standard.Http.Response;
    using ConcordInterview.Standard.Utilities;
    using ConcordInterview.Tests.Helpers;
    using Newtonsoft.Json.Converters;
    using NUnit.Framework;

    /// <summary>
    /// MiscControllerTest.
    /// </summary>
    [TestFixture]
    public class MiscControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private MiscController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.MiscController;
        }

        /// <summary>
        /// TestListCountries.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestListCountries()
        {
            // Perform API call
            try
            {
                await this.controller.ListCountriesAsync();
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestListStates.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestListStates()
        {
            // Parameters for the API call
            Standard.Models.ListStatesRequest body = ApiHelper.JsonDeserialize<Standard.Models.ListStatesRequest>("{
  \"country_code\": \"IN\"
}");

            // Perform API call
            try
            {
                await this.controller.ListStatesAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestListCities.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestListCities()
        {
            // Parameters for the API call
            Standard.Models.ListCitiesRequest body = ApiHelper.JsonDeserialize<Standard.Models.ListCitiesRequest>("{
  \"country_code\": \"IN\",
  \"state_code\": \"RJ\"
}");

            // Perform API call
            try
            {
                await this.controller.ListCitiesAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }

        /// <summary>
        /// TestRegister.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestRegister()
        {
            // Parameters for the API call
            Standard.Models.RegisterRequest body = ApiHelper.JsonDeserialize<Standard.Models.RegisterRequest>("{
  \"first_name\": \"user first name\",
  \"last_name\": \"user last name\",
  \"email\": \"testuser@gmail.com\",
  \"address1\": \"test 01\",
  \"address2\": \"test street\",
  \"country\": \"India\",
  \"state\": \"Tamil Nadu\",
  \"city\": \"Chennai\"
}");

            // Perform API call
            try
            {
                await this.controller.RegisterAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, this.HttpCallBackHandler.Response.StatusCode, "Status should be 200");
        }
    }
}