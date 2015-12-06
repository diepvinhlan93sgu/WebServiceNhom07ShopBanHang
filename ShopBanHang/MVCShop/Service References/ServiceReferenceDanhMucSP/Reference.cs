﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCShop.ServiceReferenceDanhMucSP {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DanhMucSP", Namespace="http://schemas.datacontract.org/2004/07/ShopBanHang")]
    [System.SerializableAttribute()]
    public partial class DanhMucSP : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaDMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenDMField;
        
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
        public string MaDM {
            get {
                return this.MaDMField;
            }
            set {
                if ((object.ReferenceEquals(this.MaDMField, value) != true)) {
                    this.MaDMField = value;
                    this.RaisePropertyChanged("MaDM");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenDM {
            get {
                return this.TenDMField;
            }
            set {
                if ((object.ReferenceEquals(this.TenDMField, value) != true)) {
                    this.TenDMField = value;
                    this.RaisePropertyChanged("TenDM");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDanhMucSP.IServiceDanhMucSP")]
    public interface IServiceDanhMucSP {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDanhMucSP/All", ReplyAction="http://tempuri.org/IServiceDanhMucSP/AllResponse")]
        MVCShop.ServiceReferenceDanhMucSP.DanhMucSP[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDanhMucSP/All", ReplyAction="http://tempuri.org/IServiceDanhMucSP/AllResponse")]
        System.Threading.Tasks.Task<MVCShop.ServiceReferenceDanhMucSP.DanhMucSP[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDanhMucSP/ThemDanhmuc", ReplyAction="http://tempuri.org/IServiceDanhMucSP/ThemDanhmucResponse")]
        bool ThemDanhmuc(string madm, string tendm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDanhMucSP/ThemDanhmuc", ReplyAction="http://tempuri.org/IServiceDanhMucSP/ThemDanhmucResponse")]
        System.Threading.Tasks.Task<bool> ThemDanhmucAsync(string madm, string tendm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDanhMucSP/SuaDanhmuc", ReplyAction="http://tempuri.org/IServiceDanhMucSP/SuaDanhmucResponse")]
        bool SuaDanhmuc(string dmht, string madm, string tendm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDanhMucSP/SuaDanhmuc", ReplyAction="http://tempuri.org/IServiceDanhMucSP/SuaDanhmucResponse")]
        System.Threading.Tasks.Task<bool> SuaDanhmucAsync(string dmht, string madm, string tendm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDanhMucSP/XoaDanhmuc", ReplyAction="http://tempuri.org/IServiceDanhMucSP/XoaDanhmucResponse")]
        bool XoaDanhmuc(string IDUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDanhMucSP/XoaDanhmuc", ReplyAction="http://tempuri.org/IServiceDanhMucSP/XoaDanhmucResponse")]
        System.Threading.Tasks.Task<bool> XoaDanhmucAsync(string IDUser);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDanhMucSPChannel : MVCShop.ServiceReferenceDanhMucSP.IServiceDanhMucSP, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDanhMucSPClient : System.ServiceModel.ClientBase<MVCShop.ServiceReferenceDanhMucSP.IServiceDanhMucSP>, MVCShop.ServiceReferenceDanhMucSP.IServiceDanhMucSP {
        
        public ServiceDanhMucSPClient() {
        }
        
        public ServiceDanhMucSPClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDanhMucSPClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDanhMucSPClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDanhMucSPClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MVCShop.ServiceReferenceDanhMucSP.DanhMucSP[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<MVCShop.ServiceReferenceDanhMucSP.DanhMucSP[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public bool ThemDanhmuc(string madm, string tendm) {
            return base.Channel.ThemDanhmuc(madm, tendm);
        }
        
        public System.Threading.Tasks.Task<bool> ThemDanhmucAsync(string madm, string tendm) {
            return base.Channel.ThemDanhmucAsync(madm, tendm);
        }
        
        public bool SuaDanhmuc(string dmht, string madm, string tendm) {
            return base.Channel.SuaDanhmuc(dmht, madm, tendm);
        }
        
        public System.Threading.Tasks.Task<bool> SuaDanhmucAsync(string dmht, string madm, string tendm) {
            return base.Channel.SuaDanhmucAsync(dmht, madm, tendm);
        }
        
        public bool XoaDanhmuc(string IDUser) {
            return base.Channel.XoaDanhmuc(IDUser);
        }
        
        public System.Threading.Tasks.Task<bool> XoaDanhmucAsync(string IDUser) {
            return base.Channel.XoaDanhmucAsync(IDUser);
        }
    }
}
