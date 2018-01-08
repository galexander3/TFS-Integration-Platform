﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.TeamFoundation.Migration.ClearQuestAdapter {
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
    public class ClearQuestResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ClearQuestResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.TeamFoundation.Migration.ClearQuestAdapter.ClearQuestResource", typeof(ClearQuestResource).Assembly);
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
        ///   Looks up a localized string similar to The login credential setting in the ClearQuest migraiton source configuration is not complete..
        /// </summary>
        public static string ClearQuest_Config_IncompleteLoginCredentialSetting {
            get {
                return ResourceManager.GetString("ClearQuest_Config_IncompleteLoginCredentialSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configuration of the ClearQuest migraiton source does not have a valid login credential setting type..
        /// </summary>
        public static string ClearQuest_Config_MissingLoginCredentialSettingType {
            get {
                return ResourceManager.GetString("ClearQuest_Config_MissingLoginCredentialSettingType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The login credential setting type in the ClearQuest migraiton source configuration is not supported..
        /// </summary>
        public static string ClearQuest_Config_UnknownLoginCredentialSettingType {
            get {
                return ResourceManager.GetString("ClearQuest_Config_UnknownLoginCredentialSettingType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolving ClearQuest invalid field value conflict by adding a field map for mandatory field..
        /// </summary>
        public static string ClearQuest_Conflict_Action_AddFieldMap {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_Action_AddFieldMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolving ClearQuest invalid field value conflict by dropping the conflicted field..
        /// </summary>
        public static string ClearQuest_Conflict_Action_DropField {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_Action_DropField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skip setting a field value to resolve a ClearQuest migration conflict..
        /// </summary>
        public static string ClearQuest_Conflict_Action_DropValueSetting {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_Action_DropValueSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use Regex-based string replacement to transform a field value and resolve a ClearQuest migration conflict..
        /// </summary>
        public static string ClearQuest_Conflict_Action_RegexValueReplacement {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_Action_RegexValueReplacement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolving ClearQuest invalid field value conflict by adding a value map..
        /// </summary>
        public static string ClearQuest_Conflict_Action_UseValueMap {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_Action_UseValueMap", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This conflict is detected when an unhandled exception is caught at adapter interface boundary..
        /// </summary>
        public static string ClearQuest_Conflict_GenericConflict_Desc {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_GenericConflict_Desc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClearQuest adapter generic conflict.
        /// </summary>
        public static string ClearQuest_Conflict_GenericConflict_Name {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_GenericConflict_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This conflict is detected when there is an error initializing the ClearQuest adapter..
        /// </summary>
        public static string ClearQuest_Conflict_InitConflict_Desc {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_InitConflict_Desc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClearQuest adapter initialization conflict.
        /// </summary>
        public static string ClearQuest_Conflict_InitConflict_Name {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_InitConflict_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This conflict is detected when the ClearQuest login user does not have sufficent privilege to complete the migration session..
        /// </summary>
        public static string ClearQuest_Conflict_InsufficentPrivilege_Desc {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_InsufficentPrivilege_Desc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClearQuest adapter insufficent user privilege conflict.
        /// </summary>
        public static string ClearQuest_Conflict_InsufficentPrivilege_Name {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_InsufficentPrivilege_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User &apos;{0}&apos; does not have ClearQuest user privilege &apos;{1}&apos; that&apos;s required to complete the migration session..
        /// </summary>
        public static string ClearQuest_Conflict_InsufficientPrivilege_DetailsFormat {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_InsufficientPrivilege_DetailsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClearQuest invalid field value conflict type.
        /// </summary>
        public static string ClearQuest_Conflict_InvalidFieldValue_Name {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_InvalidFieldValue_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This conflict is detected when the ClearQuest adapter fails to find the ClearQuest COM DLL..
        /// </summary>
        public static string ClearQuest_Conflict_MisingCQCom_Desc {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_MisingCQCom_Desc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClearQuest adapter missing ClearQuest COM dll conflict.
        /// </summary>
        public static string ClearQuest_Conflict_MisingCQCom_Name {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_MisingCQCom_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing resolution data: {0}..
        /// </summary>
        public static string ClearQuest_Conflict_MissingResolutionData {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_MissingResolutionData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This conflict is detected when ClearQuest Interop returns an error string when setting a field value..
        /// </summary>
        public static string ClearQuest_Conflict_SetFieldConflict_Desc {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_SetFieldConflict_Desc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to migrate source Work Item (Id: {0}, Rev: {1}) due to error in setting target ClearQuest Record field &apos;{2}&apos; with value &apos;{3}&apos;. ClearQuest returned the following error:
        ///{4}.
        /// </summary>
        public static string ClearQuest_Conflict_SetFieldConflict_DtlsFormat {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_SetFieldConflict_DtlsFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ClearQuest adapter set field conflict.
        /// </summary>
        public static string ClearQuest_Conflict_SetFieldConflict_Name {
            get {
                return ResourceManager.GetString("ClearQuest_Conflict_SetFieldConflict_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is not stored credential availlable for the resource (Uri: {0})..
        /// </summary>
        public static string ClearQuest_Error_CredntialMissing {
            get {
                return ResourceManager.GetString("ClearQuest_Error_CredntialMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action description of the migration action &apos;{0}&apos; is invalid..
        /// </summary>
        public static string ClearQuest_Error_InvalidActionDescription {
            get {
                return ResourceManager.GetString("ClearQuest_Error_InvalidActionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to login to UserDB &apos;{0}&apos; of DBSet &apos;{1}&apos; with Session Type &apos;{2}&apos; as User &apos;{3}&apos;..
        /// </summary>
        public static string ClearQuest_Error_LoginFailure {
            get {
                return ResourceManager.GetString("ClearQuest_Error_LoginFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resolved conflict &apos;{0}&apos;..
        /// </summary>
        public static string ClearQuest_Msg_ConflictResolved {
            get {
                return ResourceManager.GetString("ClearQuest_Msg_ConflictResolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to resolve conflict &apos;{0}&apos;..
        /// </summary>
        public static string ClearQuest_Msg_ConflictUnresolved {
            get {
                return ResourceManager.GetString("ClearQuest_Msg_ConflictUnresolved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; &apos;{1}&apos; has been deleted on the ClearQuest server..
        /// </summary>
        public static string ClearQuest_Msg_RecordDeleted {
            get {
                return ResourceManager.GetString("ClearQuest_Msg_RecordDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Author: {0}
        ///Change Date: {1}
        ///
        ///----- Change Details -----
        ///.
        /// </summary>
        public static string ClearQuest_Msg_UpdateLogHeaderFormat {
            get {
                return ResourceManager.GetString("ClearQuest_Msg_UpdateLogHeaderFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to rev {0}.
        /// </summary>
        public static string ClearQuest_Msg_UpdateLogRevFormat {
            get {
                return ResourceManager.GetString("ClearQuest_Msg_UpdateLogRevFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using Windows Credential Store to preserve ClearQuest login information is not supported on the current Operating System..
        /// </summary>
        public static string StoredCredentialNotSupported {
            get {
                return ResourceManager.GetString("StoredCredentialNotSupported", resourceCulture);
            }
        }
    }
}
