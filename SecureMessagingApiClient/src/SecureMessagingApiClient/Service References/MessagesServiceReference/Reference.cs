﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecureMessagingApiClient.MessagesServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="listresponse", Namespace="http://api.relayhealth.com/2012/05/types")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.attachmentlistresponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.addressbookitemlistresponse))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.messagelistresponse))]
    public partial class listresponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalCountField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalCount {
            get {
                return this.TotalCountField;
            }
            set {
                if ((this.TotalCountField.Equals(value) != true)) {
                    this.TotalCountField = value;
                    this.RaisePropertyChanged("TotalCount");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="attachmentlistresponse", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class attachmentlistresponse : SecureMessagingApiClient.MessagesServiceReference.listresponse {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="addressbookitemlistresponse", Namespace="http://api.relayhealth.com/2012/05/addressing/types")]
    [System.SerializableAttribute()]
    public partial class addressbookitemlistresponse : SecureMessagingApiClient.MessagesServiceReference.listresponse {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="messagelistresponse", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class messagelistresponse : SecureMessagingApiClient.MessagesServiceReference.listresponse {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.messagelistitem[] MessagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.messagelistitem[] Messages {
            get {
                return this.MessagesField;
            }
            set {
                if ((object.ReferenceEquals(this.MessagesField, value) != true)) {
                    this.MessagesField = value;
                    this.RaisePropertyChanged("Messages");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="messagelistitem", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class messagelistitem : SecureMessagingApiClient.MessagesServiceReference.messagebase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.attachmentbase[] AttachmentsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.attachmentbase[] Attachments {
            get {
                return this.AttachmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.AttachmentsField, value) != true)) {
                    this.AttachmentsField = value;
                    this.RaisePropertyChanged("Attachments");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="messagebase", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.message))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.messagelistitem))]
    public partial class messagebase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BodyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.address[] CCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> CreatedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.dispositionType[] DispositionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.address FromField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.patientidentifier[] PatientIdentifiersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ReceivedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> SentDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.messagestate StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubjectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.address[] ToField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Body {
            get {
                return this.BodyField;
            }
            set {
                if ((object.ReferenceEquals(this.BodyField, value) != true)) {
                    this.BodyField = value;
                    this.RaisePropertyChanged("Body");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.address[] CC {
            get {
                return this.CCField;
            }
            set {
                if ((object.ReferenceEquals(this.CCField, value) != true)) {
                    this.CCField = value;
                    this.RaisePropertyChanged("CC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> CreatedDate {
            get {
                return this.CreatedDateField;
            }
            set {
                if ((this.CreatedDateField.Equals(value) != true)) {
                    this.CreatedDateField = value;
                    this.RaisePropertyChanged("CreatedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.dispositionType[] Dispositions {
            get {
                return this.DispositionsField;
            }
            set {
                if ((object.ReferenceEquals(this.DispositionsField, value) != true)) {
                    this.DispositionsField = value;
                    this.RaisePropertyChanged("Dispositions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.address From {
            get {
                return this.FromField;
            }
            set {
                if ((object.ReferenceEquals(this.FromField, value) != true)) {
                    this.FromField = value;
                    this.RaisePropertyChanged("From");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.patientidentifier[] PatientIdentifiers {
            get {
                return this.PatientIdentifiersField;
            }
            set {
                if ((object.ReferenceEquals(this.PatientIdentifiersField, value) != true)) {
                    this.PatientIdentifiersField = value;
                    this.RaisePropertyChanged("PatientIdentifiers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReceivedDate {
            get {
                return this.ReceivedDateField;
            }
            set {
                if ((this.ReceivedDateField.Equals(value) != true)) {
                    this.ReceivedDateField = value;
                    this.RaisePropertyChanged("ReceivedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> SentDate {
            get {
                return this.SentDateField;
            }
            set {
                if ((this.SentDateField.Equals(value) != true)) {
                    this.SentDateField = value;
                    this.RaisePropertyChanged("SentDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.messagestate State {
            get {
                return this.StateField;
            }
            set {
                if ((this.StateField.Equals(value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject {
            get {
                return this.SubjectField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectField, value) != true)) {
                    this.SubjectField = value;
                    this.RaisePropertyChanged("Subject");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.address[] To {
            get {
                return this.ToField;
            }
            set {
                if ((object.ReferenceEquals(this.ToField, value) != true)) {
                    this.ToField = value;
                    this.RaisePropertyChanged("To");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="address", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.addresstype TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.addresstype Type {
            get {
                return this.TypeField;
            }
            set {
                if ((this.TypeField.Equals(value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="message", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class message : SecureMessagingApiClient.MessagesServiceReference.messagebase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SecureMessagingApiClient.MessagesServiceReference.attachment[] AttachmentsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SecureMessagingApiClient.MessagesServiceReference.attachment[] Attachments {
            get {
                return this.AttachmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.AttachmentsField, value) != true)) {
                    this.AttachmentsField = value;
                    this.RaisePropertyChanged("Attachments");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="dispositionType", Namespace="http://api.relayhealth.com/2012/06/messaging/types")]
    public enum dispositionType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unspecified = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Displayed = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Dispatched = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Processed = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Deleted = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Denied = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Failed = 6,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="patientidentifier", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class patientidentifier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AssigningAuthorityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NamespaceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AssigningAuthority {
            get {
                return this.AssigningAuthorityField;
            }
            set {
                if ((object.ReferenceEquals(this.AssigningAuthorityField, value) != true)) {
                    this.AssigningAuthorityField = value;
                    this.RaisePropertyChanged("AssigningAuthority");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Namespace {
            get {
                return this.NamespaceField;
            }
            set {
                if ((object.ReferenceEquals(this.NamespaceField, value) != true)) {
                    this.NamespaceField = value;
                    this.RaisePropertyChanged("Namespace");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="messagestate", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    public enum messagestate : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unspecified = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AuthorizationPassed = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AuthorizationFailed = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InputValidationPassed = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InputValidationFailed = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VirusScanPassed = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        VirusScanFailed = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Submitted = 7,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="attachmentbase", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.attachment))]
    public partial class attachmentbase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentMimeTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EncodingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FileSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContentMimeType {
            get {
                return this.ContentMimeTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentMimeTypeField, value) != true)) {
                    this.ContentMimeTypeField = value;
                    this.RaisePropertyChanged("ContentMimeType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Encoding {
            get {
                return this.EncodingField;
            }
            set {
                if ((object.ReferenceEquals(this.EncodingField, value) != true)) {
                    this.EncodingField = value;
                    this.RaisePropertyChanged("Encoding");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FileSize {
            get {
                return this.FileSizeField;
            }
            set {
                if ((this.FileSizeField.Equals(value) != true)) {
                    this.FileSizeField = value;
                    this.RaisePropertyChanged("FileSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="addresstype", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    public enum addresstype : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unspecified = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Direct = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Email = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fax = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="attachment", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class attachment : SecureMessagingApiClient.MessagesServiceReference.attachmentbase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ContentField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="fault", Namespace="http://api.relayhealth.com/2012/05/types")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.invalidinputfault))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.accessdeniedfault))]
    public partial class fault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="invalidinputfault", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class invalidinputfault : SecureMessagingApiClient.MessagesServiceReference.fault {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="accessdeniedfault", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
    [System.SerializableAttribute()]
    public partial class accessdeniedfault : SecureMessagingApiClient.MessagesServiceReference.fault {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://api.relayhealth.com/2012/06/messaging", ConfigurationName="MessagesServiceReference.messages")]
    public interface messages {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://api.relayhealth.com/2012/06/messaging/messages/get", ReplyAction="http://api.relayhealth.com/2012/06/messaging/messages/getResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.accessdeniedfault), Action="http://api.relayhealth.com/2012/06/messaging/messages/getAccessDeniedFaultFault", Name="accessdeniedfault", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.fault), Action="http://api.relayhealth.com/2012/06/messaging/messages/getFaultFault", Name="fault", Namespace="http://api.relayhealth.com/2012/05/types")]
        [System.ServiceModel.FaultContractAttribute(typeof(SecureMessagingApiClient.MessagesServiceReference.invalidinputfault), Action="http://api.relayhealth.com/2012/06/messaging/messages/getInvalidInputFaultFault", Name="invalidinputfault", Namespace="http://api.relayhealth.com/2012/05/messaging/types")]
        SecureMessagingApiClient.MessagesServiceReference.messagelistresponse get(string request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface messagesChannel : SecureMessagingApiClient.MessagesServiceReference.messages, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class messagesClient : System.ServiceModel.ClientBase<SecureMessagingApiClient.MessagesServiceReference.messages>, SecureMessagingApiClient.MessagesServiceReference.messages {
        
        public messagesClient() {
        }
        
        public messagesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public messagesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public messagesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public messagesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SecureMessagingApiClient.MessagesServiceReference.messagelistresponse get(string request) {
            return base.Channel.get(request);
        }
    }
}