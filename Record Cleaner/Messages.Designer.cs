﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecordCleaner {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RecordCleaner.Messages", typeof(Messages).Assembly);
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
        ///   Looks up a localized string similar to There was an error cleaning the file:
        ///{0}.
        /// </summary>
        internal static string CleanError {
            get {
                return ResourceManager.GetString("CleanError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done!.
        /// </summary>
        internal static string CleanSuccess {
            get {
                return ResourceManager.GetString("CleanSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error reading the dictionary:
        ///{0}.
        /// </summary>
        internal static string Dictionary_LoadError {
            get {
                return ResourceManager.GetString("Dictionary_LoadError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This program only works with dictionaries that have record types..
        /// </summary>
        internal static string Dictionary_NoRecordType {
            get {
                return ResourceManager.GetString("Dictionary_NoRecordType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This program only supports one-level dictionaries..
        /// </summary>
        internal static string Dictionary_TwoLevelError {
            get {
                return ResourceManager.GetString("Dictionary_TwoLevelError", resourceCulture);
            }
        }
    }
}
