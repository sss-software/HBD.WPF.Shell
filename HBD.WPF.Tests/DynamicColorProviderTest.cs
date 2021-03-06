// <copyright file="DynamicColorProviderTest.cs">Copyright ©  2016</copyright>

using System;
using System.Windows;
using HBD.WPF.AttacheControls;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HBD.WPF.Tests
{
    /// <summary>This class contains parameterized unit tests for DynamicColorProvider</summary>
    [PexClass(typeof(DynamicColorProvider))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DynamicColorProviderTest
    {
        /// <summary>Test stub for GetDynamicBackground(DependencyObject)</summary>
        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public bool GetDynamicBackgroundTest(DependencyObject element)
        {
            bool result = DynamicColorProvider.GetDynamicBackground(element);
            return result;
            // TODO: add assertions to method DynamicColorProviderTest.GetDynamicBackgroundTest(DependencyObject)
        }

        /// <summary>Test stub for SetDynamicBackground(DependencyObject, Boolean)</summary>
        [PexMethod]
        [PexAllowedException(typeof(ArgumentNullException))]
        public void SetDynamicBackgroundTest(DependencyObject element, bool value)
        {
            DynamicColorProvider.SetDynamicBackground(element, value);
            // TODO: add assertions to method DynamicColorProviderTest.SetDynamicBackgroundTest(DependencyObject, Boolean)
        }
    }
}
