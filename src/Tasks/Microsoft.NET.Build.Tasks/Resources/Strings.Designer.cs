﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.NET.Build.Tasks {
    using System;
    using System.Reflection;


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
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.NET.Build.Tasks.Resources.Strings", typeof(Strings).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Assets file &apos;{0}&apos; doesn&apos;t have a target for &apos;{1}&apos;. Ensure you have restored this project for TargetFramework=&apos;{2}&apos; and RuntimeIdentifier=&apos;{3}&apos;..
        /// </summary>
        internal static string AssetsFileMissingTarget {
            get {
                return ResourceManager.GetString("AssetsFileMissingTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assets file &apos;{0}&apos; not found. Run a NuGet package restore to generate this file..
        /// </summary>
        internal static string AssetsFileNotFound {
            get {
                return ResourceManager.GetString("AssetsFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assets file path &apos;{0}&apos; is not rooted. Only full paths are supported..
        /// </summary>
        internal static string AssetsFilePathNotRooted {
            get {
                return ResourceManager.GetString("AssetsFilePathNotRooted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one possible target framework must be specified..
        /// </summary>
        internal static string AtLeastOneTargetFrameworkMustBeSpecified {
            get {
                return ResourceManager.GetString("AtLeastOneTargetFrameworkMustBeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find project info for &apos;{0}&apos;. This can indicate a missing project reference..
        /// </summary>
        internal static string CannotFindProjectInfo {
            get {
                return ResourceManager.GetString("CannotFindProjectInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot infer TargetFrameworkIdentifier and/or TargetFrameworkVersion from TargetFramework=&apos;{0}&apos;. They must be specified explicitly..
        /// </summary>
        internal static string CannotInferTargetFrameworkIdentiferAndVersion {
            get {
                return ResourceManager.GetString("CannotInferTargetFrameworkIdentiferAndVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Content file &apos;{0}&apos; does not contain expected parent package information..
        /// </summary>
        internal static string ContentFileDoesNotContainExpectedParentPackageInformation {
            get {
                return ResourceManager.GetString("ContentFileDoesNotContainExpectedParentPackageInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Content item for &apos;{0}&apos; sets &apos;{1}&apos;, but does not provide  &apos;{2}&apos; or &apos;{3}&apos;..
        /// </summary>
        internal static string ContentItemDoesNotProvideOutputPath {
            get {
                return ResourceManager.GetString("ContentItemDoesNotProvideOutputPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; task must be given a value for parameter &apos;{1}&apos; in order to consume preprocessed content..
        /// </summary>
        internal static string ContentPreproccessorParameterRequired {
            get {
                return ResourceManager.GetString("ContentPreproccessorParameterRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The preprocessor token &apos;{0}&apos; has been given more than one value. Choosing &apos;{1}&apos; as the value..
        /// </summary>
        internal static string DuplicatePreprocessorToken {
            get {
                return ResourceManager.GetString("DuplicatePreprocessorToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Errors occured when emitting satellite assembly &apos;{0}&apos;..
        /// </summary>
        internal static string ErrorsOccurredWhenEmittingSatelliteAssembly {
            get {
                return ResourceManager.GetString("ErrorsOccurredWhenEmittingSatelliteAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid framework name: &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidFrameworkName {
            get {
                return ResourceManager.GetString("InvalidFrameworkName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing &apos;{0}&apos; metadata on &apos;{1}&apos; item &apos;{2}&apos;..
        /// </summary>
        internal static string MissingItemMetadata {
            get {
                return ResourceManager.GetString("MissingItemMetadata", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project &apos;{0}&apos; has no target framework compatible with &apos;{1}&apos;..
        /// </summary>
        internal static string NoCompatibleTargetFramework {
            get {
                return ResourceManager.GetString("NoCompatibleTargetFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Assets are consumed from project &apos;{0}&apos;, but no corresponding MSBuild project path was  found in &apos;{1}&apos;..
        /// </summary>
        internal static string ProjectAssetsConsumedWithoutMSBuildProjectPath {
            get {
                return ResourceManager.GetString("ProjectAssetsConsumedWithoutMSBuildProjectPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RuntimeIdentifier must be set for .NETFramework executables. Consider RuntimeIdentifier=win7-x86 or RuntimeIdentifier=win7-x64..
        /// </summary>
        internal static string RuntimeIdentifierMustBeSetForNETFramework {
            get {
                return ResourceManager.GetString("RuntimeIdentifierMustBeSetForNETFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to find resolved path for &apos;{0}&apos;..
        /// </summary>
        internal static string UnableToFindResolvedPath {
            get {
                return ResourceManager.GetString("UnableToFindResolvedPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected dependency &apos;{0}&apos; with no version number..
        /// </summary>
        internal static string UnexpectedDependencyWithNoVersionNumber {
            get {
                return ResourceManager.GetString("UnexpectedDependencyWithNoVersionNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected file group in assets file for target library &apos;{0}&apos;..
        /// </summary>
        internal static string UnexpectedFileGroupInAssetsFile {
            get {
                return ResourceManager.GetString("UnexpectedFileGroupInAssetsFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected file type for &apos;{0}&apos;. Type is both &apos;{1}&apos; and &apos;{2}&apos;..
        /// </summary>
        internal static string UnexpectedFileType {
            get {
                return ResourceManager.GetString("UnexpectedFileType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized preprocessor token &apos;{0}&apos; in &apos;{1}&apos;..
        /// </summary>
        internal static string UnrecognizedPreprocessorToken {
            get {
                return ResourceManager.GetString("UnrecognizedPreprocessorToken", resourceCulture);
            }
        }
    }
}
