﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalXMVC.AuthServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterDTO", Namespace="http://schemas.datacontract.org/2004/07/AuthService")]
    [System.SerializableAttribute()]
    public partial class RegisterDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthServiceReference.IAuthService")]
    public interface IAuthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Login", ReplyAction="http://tempuri.org/IAuthService/LoginResponse")]
        bool Login(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Login", ReplyAction="http://tempuri.org/IAuthService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Register", ReplyAction="http://tempuri.org/IAuthService/RegisterResponse")]
        int Register(DigitalXMVC.AuthServiceReference.RegisterDTO regData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Register", ReplyAction="http://tempuri.org/IAuthService/RegisterResponse")]
        System.Threading.Tasks.Task<int> RegisterAsync(DigitalXMVC.AuthServiceReference.RegisterDTO regData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/ProductGetAll", ReplyAction="http://tempuri.org/IAuthService/ProductGetAllResponse")]
        DigitalXData.Product[] ProductGetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/ProductGetAll", ReplyAction="http://tempuri.org/IAuthService/ProductGetAllResponse")]
        System.Threading.Tasks.Task<DigitalXData.Product[]> ProductGetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/ProductGetDetails", ReplyAction="http://tempuri.org/IAuthService/ProductGetDetailsResponse")]
        DigitalXData.Product ProductGetDetails(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/ProductGetDetails", ReplyAction="http://tempuri.org/IAuthService/ProductGetDetailsResponse")]
        System.Threading.Tasks.Task<DigitalXData.Product> ProductGetDetailsAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/ProductGetTop", ReplyAction="http://tempuri.org/IAuthService/ProductGetTopResponse")]
        DigitalXData.Product[] ProductGetTop(int count);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/ProductGetTop", ReplyAction="http://tempuri.org/IAuthService/ProductGetTopResponse")]
        System.Threading.Tasks.Task<DigitalXData.Product[]> ProductGetTopAsync(int count);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthServiceChannel : DigitalXMVC.AuthServiceReference.IAuthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceClient : System.ServiceModel.ClientBase<DigitalXMVC.AuthServiceReference.IAuthService>, DigitalXMVC.AuthServiceReference.IAuthService {
        
        public AuthServiceClient() {
        }
        
        public AuthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string userName, string password) {
            return base.Channel.Login(userName, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string userName, string password) {
            return base.Channel.LoginAsync(userName, password);
        }
        
        public int Register(DigitalXMVC.AuthServiceReference.RegisterDTO regData) {
            return base.Channel.Register(regData);
        }
        
        public System.Threading.Tasks.Task<int> RegisterAsync(DigitalXMVC.AuthServiceReference.RegisterDTO regData) {
            return base.Channel.RegisterAsync(regData);
        }
        
        public DigitalXData.Product[] ProductGetAll() {
            return base.Channel.ProductGetAll();
        }
        
        public System.Threading.Tasks.Task<DigitalXData.Product[]> ProductGetAllAsync() {
            return base.Channel.ProductGetAllAsync();
        }
        
        public DigitalXData.Product ProductGetDetails(System.Nullable<int> id) {
            return base.Channel.ProductGetDetails(id);
        }
        
        public System.Threading.Tasks.Task<DigitalXData.Product> ProductGetDetailsAsync(System.Nullable<int> id) {
            return base.Channel.ProductGetDetailsAsync(id);
        }
        
        public DigitalXData.Product[] ProductGetTop(int count) {
            return base.Channel.ProductGetTop(count);
        }
        
        public System.Threading.Tasks.Task<DigitalXData.Product[]> ProductGetTopAsync(int count) {
            return base.Channel.ProductGetTopAsync(count);
        }
    }
}
