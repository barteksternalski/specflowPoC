﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace specflowPoC.Locators {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LandingPageLocators {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LandingPageLocators() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("specflowPoC.Locators.LandingPageLocators", typeof(LandingPageLocators).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //*[contains(@class,&apos;__logo&apos;)].
        /// </summary>
        internal static string XPATH_logoIcon {
            get {
                return ResourceManager.GetString("XPATH_logoIcon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //button[contains(@class,&apos;logout&apos;)].
        /// </summary>
        internal static string XPATH_logoutButton {
            get {
                return ResourceManager.GetString("XPATH_logoutButton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //a[contains(@routerlink,&apos;{0}&apos;)].
        /// </summary>
        internal static string XPATH_navigationLink {
            get {
                return ResourceManager.GetString("XPATH_navigationLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //main/h1.
        /// </summary>
        internal static string XPATH_pageTitle {
            get {
                return ResourceManager.GetString("XPATH_pageTitle", resourceCulture);
            }
        }
    }
}
