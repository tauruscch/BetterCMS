﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterCms.Module.Newsletter.Content.Resources {
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
    public class NewsletterGlobalization {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NewsletterGlobalization() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BetterCms.Module.Newsletter.Content.Resources.NewsletterGlobalization", typeof(NewsletterGlobalization).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Newsletter subscriber created successfully..
        /// </summary>
        public static string CreateSubscriber_CreatedSuccessfully_Message {
            get {
                return ResourceManager.GetString("CreateSubscriber_CreatedSuccessfully_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete newsletter subscriber {0}?.
        /// </summary>
        public static string DeleteSubscriber_Confirmation_Message {
            get {
                return ResourceManager.GetString("DeleteSubscriber_Confirmation_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Newsletter subscriber deleted successfully..
        /// </summary>
        public static string DeleteSubscriber_DeletedSuccessfully_Message {
            get {
                return ResourceManager.GetString("DeleteSubscriber_DeletedSuccessfully_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscriber email is invalid..
        /// </summary>
        public static string EditSubscriber_IvalidEmail_Message {
            get {
                return ResourceManager.GetString("EditSubscriber_IvalidEmail_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscriber with email {0} already exists..
        /// </summary>
        public static string SaveSubscriberCommand_EmailAlreadyExists_Message {
            get {
                return ResourceManager.GetString("SaveSubscriberCommand_EmailAlreadyExists_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email Address.
        /// </summary>
        public static string SiteSettings_NewsletterSubscribers_Email_Title {
            get {
                return ResourceManager.GetString("SiteSettings_NewsletterSubscribers_Email_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Newsletter subscribers.
        /// </summary>
        public static string SiteSettings_NewsletterSubscribers_Title {
            get {
                return ResourceManager.GetString("SiteSettings_NewsletterSubscribers_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Newsletter subscribers.
        /// </summary>
        public static string SiteSettings_NewsletterSubscribersMenuItem {
            get {
                return ResourceManager.GetString("SiteSettings_NewsletterSubscribersMenuItem", resourceCulture);
            }
        }
    }
}
