﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopWinForm.ServiceSanPhamCustom {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SanPhamCustom", Namespace="http://schemas.datacontract.org/2004/07/ShopBanHang")]
    [System.SerializableAttribute()]
    public partial class SanPhamCustom : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> GiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HinhAnhField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KichThuocField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaDMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MauSacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MoTaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SoLuongField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenDMField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TenSPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> TrangThaiField;
        
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
        public System.Nullable<decimal> Gia {
            get {
                return this.GiaField;
            }
            set {
                if ((this.GiaField.Equals(value) != true)) {
                    this.GiaField = value;
                    this.RaisePropertyChanged("Gia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HinhAnh {
            get {
                return this.HinhAnhField;
            }
            set {
                if ((object.ReferenceEquals(this.HinhAnhField, value) != true)) {
                    this.HinhAnhField = value;
                    this.RaisePropertyChanged("HinhAnh");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string KichThuoc {
            get {
                return this.KichThuocField;
            }
            set {
                if ((object.ReferenceEquals(this.KichThuocField, value) != true)) {
                    this.KichThuocField = value;
                    this.RaisePropertyChanged("KichThuoc");
                }
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
        public int MaSP {
            get {
                return this.MaSPField;
            }
            set {
                if ((this.MaSPField.Equals(value) != true)) {
                    this.MaSPField = value;
                    this.RaisePropertyChanged("MaSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MauSac {
            get {
                return this.MauSacField;
            }
            set {
                if ((object.ReferenceEquals(this.MauSacField, value) != true)) {
                    this.MauSacField = value;
                    this.RaisePropertyChanged("MauSac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MoTa {
            get {
                return this.MoTaField;
            }
            set {
                if ((object.ReferenceEquals(this.MoTaField, value) != true)) {
                    this.MoTaField = value;
                    this.RaisePropertyChanged("MoTa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SoLuong {
            get {
                return this.SoLuongField;
            }
            set {
                if ((object.ReferenceEquals(this.SoLuongField, value) != true)) {
                    this.SoLuongField = value;
                    this.RaisePropertyChanged("SoLuong");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TenSP {
            get {
                return this.TenSPField;
            }
            set {
                if ((object.ReferenceEquals(this.TenSPField, value) != true)) {
                    this.TenSPField = value;
                    this.RaisePropertyChanged("TenSP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> TrangThai {
            get {
                return this.TrangThaiField;
            }
            set {
                if ((this.TrangThaiField.Equals(value) != true)) {
                    this.TrangThaiField = value;
                    this.RaisePropertyChanged("TrangThai");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceSanPhamCustom.IServiceSanPhamCustom")]
    public interface IServiceSanPhamCustom {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPhamCustom/All", ReplyAction="http://tempuri.org/IServiceSanPhamCustom/AllResponse")]
        ShopWinForm.ServiceSanPhamCustom.SanPhamCustom[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSanPhamCustom/All", ReplyAction="http://tempuri.org/IServiceSanPhamCustom/AllResponse")]
        System.Threading.Tasks.Task<ShopWinForm.ServiceSanPhamCustom.SanPhamCustom[]> AllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSanPhamCustomChannel : ShopWinForm.ServiceSanPhamCustom.IServiceSanPhamCustom, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSanPhamCustomClient : System.ServiceModel.ClientBase<ShopWinForm.ServiceSanPhamCustom.IServiceSanPhamCustom>, ShopWinForm.ServiceSanPhamCustom.IServiceSanPhamCustom {
        
        public ServiceSanPhamCustomClient() {
        }
        
        public ServiceSanPhamCustomClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSanPhamCustomClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSanPhamCustomClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSanPhamCustomClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ShopWinForm.ServiceSanPhamCustom.SanPhamCustom[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<ShopWinForm.ServiceSanPhamCustom.SanPhamCustom[]> AllAsync() {
            return base.Channel.AllAsync();
        }
    }
}
