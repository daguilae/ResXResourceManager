//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// 
// This template generates PublicResXFileCodeGenerator compatible code plus some
// useful extensions. 
// 
// The original version provided by ResXResourceManager is restricted to resource key names
// that are valid c# identifiers to keep this template simple (KISS!).
// 
// Us it as it is or as a scaffold to generate the code you need.
//
// As long as you have ResXResourceManager running in the background, the generated code 
// will be kept up to date.
//  
//------------------------------------------------------------------------------

namespace tomenglertde.ResXManager.Model.Properties {
    using System;
    using System.Diagnostics.Contracts;

    using JetBrains.Annotations;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by a text template.
    // To add or remove a member, edit your .ResX file.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ResXResourceManager", "1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("tomenglertde.ResXManager.Model.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Duplicate keys in '{0}':&amp;#13;&amp;#10;{1}&amp;....
        /// </summary>
        [NotNull]
        public static string DuplicateKeyError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("DuplicateKeyError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Show an error message and don't load the resource.
        /// </summary>
        [NotNull]
        public static string DuplicateKeyHandling_Fail {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("DuplicateKeyHandling_Fail", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Postfix duplicate/empty keys with "_Duplicate[#]"/....
        /// </summary>
        [NotNull]
        public static string DuplicateKeyHandling_Rename {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("DuplicateKeyHandling_Rename", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Empty keys in '{0}'.
        /// </summary>
        [NotNull]
        public static string EmptyKeysError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("EmptyKeysError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &amp;lt;?xml version="1.0" encoding="utf-8"?&amp;g....
        /// </summary>
        [NotNull]
        public static string EmptyResxTemplate {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("EmptyResxTemplate", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Multiple sheets.
        /// </summary>
        [NotNull]
        public static string ExcelExport_MultipleSheets {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ExcelExport_MultipleSheets", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Single sheet.
        /// </summary>
        [NotNull]
        public static string ExcelExport_SingleSheet {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ExcelExport_SingleSheet", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error saving file '{0}':&amp;#13;&amp;#10;{1}&amp;....
        /// </summary>
        [NotNull]
        public static string FileSaveError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("FileSaveError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to At least three columns expected..
        /// </summary>
        [NotNull]
        public static string ImportColumnMismatchError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ImportColumnMismatchError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Duplicate language in header..
        /// </summary>
        [NotNull]
        public static string ImportDuplicateLanguageError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ImportDuplicateLanguageError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Import failed. Nothing has been imported!.
        /// </summary>
        [NotNull]
        public static string ImportFailedError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ImportFailedError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Import failed partially. Some columns have been al....
        /// </summary>
        [NotNull]
        public static string ImportFailedPartiallyError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ImportFailedPartiallyError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Standard header expected..
        /// </summary>
        [NotNull]
        public static string ImportHeaderMismatchError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ImportHeaderMismatchError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The language "{0}" can't be edited. The operation ....
        /// </summary>
        [NotNull]
        public static string ImportLanguageNotEditable {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ImportLanguageNotEditable", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The sheet "{0}" can't be imported; there is no mat....
        /// </summary>
        [NotNull]
        public static string ImportMapSheetError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("ImportMapSheetError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid RESX resource file: No xml root....
        /// </summary>
        [NotNull]
        public static string InvalidResourceFileError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("InvalidResourceFileError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid RESX resource file: Not all ent....
        /// </summary>
        [NotNull]
        public static string InvalidResourceFileNameAttributeMissingError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("InvalidResourceFileNameAttributeMissingError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid RESX resource file: Not all ent....
        /// </summary>
        [NotNull]
        public static string InvalidResourceFileValueAttributeMissingError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("InvalidResourceFileValueAttributeMissingError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Language is not defined: {0}.
        /// </summary>
        [NotNull]
        public static string LanguageNotDefinedError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("LanguageNotDefinedError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Neutral.
        /// </summary>
        [NotNull]
        public static string Neutral {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("Neutral", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Snapshot: "{0}".
        /// </summary>
        [NotNull]
        public static string SnapshotAnnotation {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("SnapshotAnnotation", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Warning: This item contains string format paramete....
        /// </summary>
        [NotNull]
        public static string StringFormatParameterMismatchError {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("StringFormatParameterMismatchError", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ResX Resource Manager.
        /// </summary>
        /// <remarks>
        /// @Invariant
        /// </remarks>
        [NotNull]
        public static string Title {
            get {
                Contract.Ensures(Contract.Result<string>() != null);
                return ResourceManager.GetString("Title", resourceCulture) ?? string.Empty;
            }
        }
    }

    /// <summary>
    /// Keys of all available strings in the applications resx-resources.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public enum StringResourceKey
    {
        /// <summary>
        ///   Looks up a localized string similar to Duplicate keys in '{0}':&amp;#13;&amp;#10;{1}&amp;....
        /// </summary>
        DuplicateKeyError,
        /// <summary>
        ///   Looks up a localized string similar to Show an error message and don't load the resource.
        /// </summary>
        DuplicateKeyHandling_Fail,
        /// <summary>
        ///   Looks up a localized string similar to Postfix duplicate/empty keys with "_Duplicate[#]"/....
        /// </summary>
        DuplicateKeyHandling_Rename,
        /// <summary>
        ///   Looks up a localized string similar to Empty keys in '{0}'.
        /// </summary>
        EmptyKeysError,
        /// <summary>
        ///   Looks up a localized string similar to &amp;lt;?xml version="1.0" encoding="utf-8"?&amp;g....
        /// </summary>
        EmptyResxTemplate,
        /// <summary>
        ///   Looks up a localized string similar to Multiple sheets.
        /// </summary>
        ExcelExport_MultipleSheets,
        /// <summary>
        ///   Looks up a localized string similar to Single sheet.
        /// </summary>
        ExcelExport_SingleSheet,
        /// <summary>
        ///   Looks up a localized string similar to Error saving file '{0}':&amp;#13;&amp;#10;{1}&amp;....
        /// </summary>
        FileSaveError,
        /// <summary>
        ///   Looks up a localized string similar to At least three columns expected..
        /// </summary>
        ImportColumnMismatchError,
        /// <summary>
        ///   Looks up a localized string similar to Duplicate language in header..
        /// </summary>
        ImportDuplicateLanguageError,
        /// <summary>
        ///   Looks up a localized string similar to Import failed. Nothing has been imported!.
        /// </summary>
        ImportFailedError,
        /// <summary>
        ///   Looks up a localized string similar to Import failed partially. Some columns have been al....
        /// </summary>
        ImportFailedPartiallyError,
        /// <summary>
        ///   Looks up a localized string similar to Standard header expected..
        /// </summary>
        ImportHeaderMismatchError,
        /// <summary>
        ///   Looks up a localized string similar to The language "{0}" can't be edited. The operation ....
        /// </summary>
        ImportLanguageNotEditable,
        /// <summary>
        ///   Looks up a localized string similar to The sheet "{0}" can't be imported; there is no mat....
        /// </summary>
        ImportMapSheetError,
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid RESX resource file: No xml root....
        /// </summary>
        InvalidResourceFileError,
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid RESX resource file: Not all ent....
        /// </summary>
        InvalidResourceFileNameAttributeMissingError,
        /// <summary>
        ///   Looks up a localized string similar to {0} is not a valid RESX resource file: Not all ent....
        /// </summary>
        InvalidResourceFileValueAttributeMissingError,
        /// <summary>
        ///   Looks up a localized string similar to Language is not defined: {0}.
        /// </summary>
        LanguageNotDefinedError,
        /// <summary>
        ///   Looks up a localized string similar to Neutral.
        /// </summary>
        Neutral,
        /// <summary>
        ///   Looks up a localized string similar to Snapshot: "{0}".
        /// </summary>
        SnapshotAnnotation,
        /// <summary>
        ///   Looks up a localized string similar to Warning: This item contains string format paramete....
        /// </summary>
        StringFormatParameterMismatchError,
        /// <summary>
        ///   Looks up a localized string similar to ResX Resource Manager.
        /// </summary>
        /// <remarks>
        /// @Invariant
        /// </remarks>
        Title,
    }

    /// <summary>
    /// Specifies a localized description for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDescriptionAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized description from the resource id stored in this attribute.
        /// </summary>
        public override string Description
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
    {
        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDisplayNameAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDisplayNameAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized display name from the resource id stored in this attribute.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedCategoryAttribute : System.ComponentModel.CategoryAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedCategoryAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedCategoryAttribute(StringResourceKey resourceKey)
            : base(resourceKey.ToString())
        {
        }

        /// <summary>
        /// Gets the localized category name from the resource id stored in this attribute.
        /// </summary>
        protected override string GetLocalizedString(string value)
        {
            return Resources.ResourceManager.GetString(value);
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class LocalizedTextAttribute : global::TomsToolbox.Desktop.TextAttribute
    {
        // This code is generated by Resources.Designer.t4
        // If you get compile errors because you don't use the TomsToolbox.Desktop NuGet package, remove this part in the Resources.Designer.t4 file. 
        // Just search for this text and follow the instructions above.

        private readonly StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedTextAttribute"/> class.
        /// </summary>
        /// <param name="key">Any user defined key to specify the usage of this text.</param>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedTextAttribute(object key, StringResourceKey resourceKey)
            : base(key)
        {
            _resourceKey = resourceKey;
        }

        /// <summary>
        /// Gets the localized text from the resource id stored in this attribute.
        /// </summary>
        public override string Text
        {
            get
            {
                return Resources.ResourceManager.GetString(_resourceKey.ToString());
            }
        }
    }

    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.DataTypeAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class DataTypeAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeAttribute"/> class.
        /// </summary>
        public DataTypeAttribute(StringResourceKey resourceKey, System.ComponentModel.DataAnnotations.DataType dataType)
            : base(dataType)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeAttribute"/> class.
        /// </summary>
        public DataTypeAttribute(StringResourceKey resourceKey, string customDataType)
            : base(customDataType)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RangeAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute : System.ComponentModel.DataAnnotations.RangeAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, int minimum, int maximum)
            : base(minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, double minimum, double maximum)
            : base(minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, Type type, string minimum, string maximum)
            : base(type, minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RegularExpressionAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.RegularExpressionAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularExpressionAttribute"/> class.
        /// </summary>
        public RegularExpressionAttribute(StringResourceKey resourceKey, string pattern)
            : base(pattern)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RequiredAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAttribute"/> class.
        /// </summary>
        public RequiredAttribute(StringResourceKey resourceKey)
            : base()
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.StringLengthAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class StringLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringLengthAttribute"/> class.
        /// </summary>
        public StringLengthAttribute(StringResourceKey resourceKey, int maximumLength)
            : base(maximumLength)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(Resources);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    

}
