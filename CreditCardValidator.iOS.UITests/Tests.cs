﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace CreditCardValidator.iOS.UITests
{
	[TestFixture]
	public class Tests
	{
		[SetUp]
		public void BeforeEachTest()
		{
			string deviceUDID = Environment.GetEnvironmentVariable ("IOS_SIMULATOR_UDID");
			deviceUDID = "6BD58FE1-A8F7-4193-9EE0-7F2E5151BAA2";
			ConfigureApp
				.iOS
				.InstalledApp("com.bitfall.creditcardvalidator")
				.DeviceIdentifier(deviceUDID)
				.StartApp();

		}

		[Test]
		public void AssertTrue()
		{
			Assert.True (true);
		}
	}
}


