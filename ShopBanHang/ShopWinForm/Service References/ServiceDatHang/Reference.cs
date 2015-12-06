﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopWinForm.ServiceDatHang {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DonHang", Namespace="http://schemas.datacontract.org/2004/07/ShopBanHang")]
    [System.SerializableAttribute()]
    public partial class DonHang : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDUserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaDonHangField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MaTrangThaiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> NgayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> TriGiaDHField;
        
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
        public string IDUser {
            get {
                return this.IDUserField;
            }
            set {
                if ((object.ReferenceEquals(this.IDUserField, value) != true)) {
                    this.IDUserField = value;
                    this.RaisePropertyChanged("IDUser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MaDonHang {
            get {
                return this.MaDonHangField;
            }
            set {
                if ((this.MaDonHangField.Equals(value) != true)) {
                    this.MaDonHangField = value;
                    this.RaisePropertyChanged("MaDonHang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MaTrangThai {
            get {
                return this.MaTrangThaiField;
            }
            set {
                if ((object.ReferenceEquals(this.MaTrangThaiField, value) != true)) {
                    this.MaTrangThaiField = value;
                    this.RaisePropertyChanged("MaTrangThai");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Ngay {
            get {
                return this.NgayField;
            }
            set {
                if ((this.NgayField.Equals(value) != true)) {
                    this.NgayField = value;
                    this.RaisePropertyChanged("Ngay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> TriGiaDH {
            get {
                return this.TriGiaDHField;
            }
            set {
                if ((this.TriGiaDHField.Equals(value) != true)) {
                    this.TriGiaDHField = value;
                    this.RaisePropertyChanged("TriGiaDH");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceDatHang.IServiceDatHang")]
    public interface IServiceDatHang {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/insertHD", ReplyAction="http://tempuri.org/IServiceDatHang/insertHDResponse")]
        bool insertHD(string IDUser, System.DateTime Ngay, decimal TriGiaDH, string matrangthai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/insertHD", ReplyAction="http://tempuri.org/IServiceDatHang/insertHDResponse")]
        System.Threading.Tasks.Task<bool> insertHDAsync(string IDUser, System.DateTime Ngay, decimal TriGiaDH, string matrangthai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/insertCTHD", ReplyAction="http://tempuri.org/IServiceDatHang/insertCTHDResponse")]
        bool insertCTHD(int MaDonHang, int MaSP, int SoLuong, decimal Gia, decimal ThanhTien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/insertCTHD", ReplyAction="http://tempuri.org/IServiceDatHang/insertCTHDResponse")]
        System.Threading.Tasks.Task<bool> insertCTHDAsync(int MaDonHang, int MaSP, int SoLuong, decimal Gia, decimal ThanhTien);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/All", ReplyAction="http://tempuri.org/IServiceDatHang/AllResponse")]
        ShopWinForm.ServiceDatHang.DonHang[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/All", ReplyAction="http://tempuri.org/IServiceDatHang/AllResponse")]
        System.Threading.Tasks.Task<ShopWinForm.ServiceDatHang.DonHang[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/DonHangTheoUser", ReplyAction="http://tempuri.org/IServiceDatHang/DonHangTheoUserResponse")]
        ShopWinForm.ServiceDatHang.DonHang[] DonHangTheoUser(string iduser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/DonHangTheoUser", ReplyAction="http://tempuri.org/IServiceDatHang/DonHangTheoUserResponse")]
        System.Threading.Tasks.Task<ShopWinForm.ServiceDatHang.DonHang[]> DonHangTheoUserAsync(string iduser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/TimTheoNgay", ReplyAction="http://tempuri.org/IServiceDatHang/TimTheoNgayResponse")]
        ShopWinForm.ServiceDatHang.DonHang[] TimTheoNgay(System.DateTime ngay);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/TimTheoNgay", ReplyAction="http://tempuri.org/IServiceDatHang/TimTheoNgayResponse")]
        System.Threading.Tasks.Task<ShopWinForm.ServiceDatHang.DonHang[]> TimTheoNgayAsync(System.DateTime ngay);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/LayMaHD", ReplyAction="http://tempuri.org/IServiceDatHang/LayMaHDResponse")]
        ShopWinForm.ServiceDatHang.DonHang LayMaHD(string iduser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/LayMaHD", ReplyAction="http://tempuri.org/IServiceDatHang/LayMaHDResponse")]
        System.Threading.Tasks.Task<ShopWinForm.ServiceDatHang.DonHang> LayMaHDAsync(string iduser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/LuuTrangThai", ReplyAction="http://tempuri.org/IServiceDatHang/LuuTrangThaiResponse")]
        bool LuuTrangThai(int MaDonHang, string matrangthai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDatHang/LuuTrangThai", ReplyAction="http://tempuri.org/IServiceDatHang/LuuTrangThaiResponse")]
        System.Threading.Tasks.Task<bool> LuuTrangThaiAsync(int MaDonHang, string matrangthai);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDatHangChannel : ShopWinForm.ServiceDatHang.IServiceDatHang, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDatHangClient : System.ServiceModel.ClientBase<ShopWinForm.ServiceDatHang.IServiceDatHang>, ShopWinForm.ServiceDatHang.IServiceDatHang {
        
        public ServiceDatHangClient() {
        }
        
        public ServiceDatHangClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDatHangClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDatHangClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDatHangClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool insertHD(string IDUser, System.DateTime Ngay, decimal TriGiaDH, string matrangthai) {
            return base.Channel.insertHD(IDUser, Ngay, TriGiaDH, matrangthai);
        }
        
        public System.Threading.Tasks.Task<bool> insertHDAsync(string IDUser, System.DateTime Ngay, decimal TriGiaDH, string matrangthai) {
            return base.Channel.insertHDAsync(IDUser, Ngay, TriGiaDH, matrangthai);
        }
        
        public bool insertCTHD(int MaDonHang, int MaSP, int SoLuong, decimal Gia, decimal ThanhTien) {
            return base.Channel.insertCTHD(MaDonHang, MaSP, SoLuong, Gia, ThanhTien);
        }
        
        public System.Threading.Tasks.Task<bool> insertCTHDAsync(int MaDonHang, int MaSP, int SoLuong, decimal Gia, decimal ThanhTien) {
            return base.Channel.insertCTHDAsync(MaDonHang, MaSP, SoLuong, Gia, ThanhTien);
        }
        
        public ShopWinForm.ServiceDatHang.DonHang[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<ShopWinForm.ServiceDatHang.DonHang[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public ShopWinForm.ServiceDatHang.DonHang[] DonHangTheoUser(string iduser) {
            return base.Channel.DonHangTheoUser(iduser);
        }
        
        public System.Threading.Tasks.Task<ShopWinForm.ServiceDatHang.DonHang[]> DonHangTheoUserAsync(string iduser) {
            return base.Channel.DonHangTheoUserAsync(iduser);
        }
        
        public ShopWinForm.ServiceDatHang.DonHang[] TimTheoNgay(System.DateTime ngay) {
            return base.Channel.TimTheoNgay(ngay);
        }
        
        public System.Threading.Tasks.Task<ShopWinForm.ServiceDatHang.DonHang[]> TimTheoNgayAsync(System.DateTime ngay) {
            return base.Channel.TimTheoNgayAsync(ngay);
        }
        
        public ShopWinForm.ServiceDatHang.DonHang LayMaHD(string iduser) {
            return base.Channel.LayMaHD(iduser);
        }
        
        public System.Threading.Tasks.Task<ShopWinForm.ServiceDatHang.DonHang> LayMaHDAsync(string iduser) {
            return base.Channel.LayMaHDAsync(iduser);
        }
        
        public bool LuuTrangThai(int MaDonHang, string matrangthai) {
            return base.Channel.LuuTrangThai(MaDonHang, matrangthai);
        }
        
        public System.Threading.Tasks.Task<bool> LuuTrangThaiAsync(int MaDonHang, string matrangthai) {
            return base.Channel.LuuTrangThaiAsync(MaDonHang, matrangthai);
        }
    }
}