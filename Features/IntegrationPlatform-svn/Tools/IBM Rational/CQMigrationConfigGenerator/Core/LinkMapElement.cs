﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 
namespace Microsoft.TeamFoundation.Converters.WorkItemTracking.CQ {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class Linking {
        
        private LinkingCustomSettings customSettingsField;
        
        private LinkingLinkTypeMapping[] linkTypeMappingsField;
        
        private string engineProviderReferenceNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public LinkingCustomSettings CustomSettings {
            get {
                return this.customSettingsField;
            }
            set {
                this.customSettingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("LinkTypeMapping", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public LinkingLinkTypeMapping[] LinkTypeMappings {
            get {
                return this.linkTypeMappingsField;
            }
            set {
                this.linkTypeMappingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EngineProviderReferenceName {
            get {
                return this.engineProviderReferenceNameField;
            }
            set {
                this.engineProviderReferenceNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LinkingCustomSettings {
        
        private string settingXmlField;
        
        private string settingXmlSchemaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SettingXml {
            get {
                return this.settingXmlField;
            }
            set {
                this.settingXmlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string SettingXmlSchema {
            get {
                return this.settingXmlSchemaField;
            }
            set {
                this.settingXmlSchemaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class LinkingLinkTypeMapping {
        
        private string leftMigrationSourceUniqueIdField;
        
        private string leftLinkTypeField;
        
        private string rightMigrationSourceUniqueIdField;
        
        private string rightLinkTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LeftMigrationSourceUniqueId {
            get {
                return this.leftMigrationSourceUniqueIdField;
            }
            set {
                this.leftMigrationSourceUniqueIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LeftLinkType {
            get {
                return this.leftLinkTypeField;
            }
            set {
                this.leftLinkTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RightMigrationSourceUniqueId {
            get {
                return this.rightMigrationSourceUniqueIdField;
            }
            set {
                this.rightMigrationSourceUniqueIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RightLinkType {
            get {
                return this.rightLinkTypeField;
            }
            set {
                this.rightLinkTypeField = value;
            }
        }
    }
}
