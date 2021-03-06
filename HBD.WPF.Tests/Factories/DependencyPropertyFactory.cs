using System.Windows;
using System.Windows.Controls;
using Microsoft.Pex.Framework;

namespace HBD.WPF.Tests.Factories
{
    /// <summary>A factory for System.Windows.DependencyProperty instances</summary>
    public static class DependencyPropertyFactory
    {
        /// <summary>A factory for System.Windows.DependencyProperty instances</summary>
        [PexFactoryMethod(typeof(DependencyProperty))]
        public static object Create()
        {
            return Control.BackgroundProperty;
        }
    }
}
