//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quanlyquancafe.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/quanlyquancafeWCF")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="coffee", Namespace="http://schemas.datacontract.org/2004/07/quanlyquancafeWCF")]
    [System.SerializableAttribute()]
    public partial class coffee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberOrderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tinhTrangField;
        
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
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numberOrder {
            get {
                return this.numberOrderField;
            }
            set {
                if ((this.numberOrderField.Equals(value) != true)) {
                    this.numberOrderField = value;
                    this.RaisePropertyChanged("numberOrder");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tinhTrang {
            get {
                return this.tinhTrangField;
            }
            set {
                if ((object.ReferenceEquals(this.tinhTrangField, value) != true)) {
                    this.tinhTrangField = value;
                    this.RaisePropertyChanged("tinhTrang");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        quanlyquancafe.ServiceReference1.CompositeType GetDataUsingDataContract(quanlyquancafe.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(quanlyquancafe.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getInfo", ReplyAction="http://tempuri.org/IService1/getInfoResponse")]
        quanlyquancafe.ServiceReference1.coffee[] getInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getInfo", ReplyAction="http://tempuri.org/IService1/getInfoResponse")]
        System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.coffee[]> getInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/findCoffee", ReplyAction="http://tempuri.org/IService1/findCoffeeResponse")]
        quanlyquancafe.ServiceReference1.coffee[] findCoffee(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/findCoffee", ReplyAction="http://tempuri.org/IService1/findCoffeeResponse")]
        System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.coffee[]> findCoffeeAsync(int a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/datMon", ReplyAction="http://tempuri.org/IService1/datMonResponse")]
        int datMon(quanlyquancafe.ServiceReference1.coffee c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/datMon", ReplyAction="http://tempuri.org/IService1/datMonResponse")]
        System.Threading.Tasks.Task<int> datMonAsync(quanlyquancafe.ServiceReference1.coffee c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Daban", ReplyAction="http://tempuri.org/IService1/DabanResponse")]
        quanlyquancafe.ServiceReference1.coffee[] Daban();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Daban", ReplyAction="http://tempuri.org/IService1/DabanResponse")]
        System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.coffee[]> DabanAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/conlai", ReplyAction="http://tempuri.org/IService1/conlaiResponse")]
        quanlyquancafe.ServiceReference1.coffee[] conlai();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/conlai", ReplyAction="http://tempuri.org/IService1/conlaiResponse")]
        System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.coffee[]> conlaiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/doanhthu", ReplyAction="http://tempuri.org/IService1/doanhthuResponse")]
        decimal doanhthu();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/doanhthu", ReplyAction="http://tempuri.org/IService1/doanhthuResponse")]
        System.Threading.Tasks.Task<decimal> doanhthuAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : quanlyquancafe.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<quanlyquancafe.ServiceReference1.IService1>, quanlyquancafe.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public quanlyquancafe.ServiceReference1.CompositeType GetDataUsingDataContract(quanlyquancafe.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(quanlyquancafe.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public quanlyquancafe.ServiceReference1.coffee[] getInfo() {
            return base.Channel.getInfo();
        }
        
        public System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.coffee[]> getInfoAsync() {
            return base.Channel.getInfoAsync();
        }
        
        public quanlyquancafe.ServiceReference1.coffee[] findCoffee(int a) {
            return base.Channel.findCoffee(a);
        }
        
        public System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.coffee[]> findCoffeeAsync(int a) {
            return base.Channel.findCoffeeAsync(a);
        }
        
        public int datMon(quanlyquancafe.ServiceReference1.coffee c) {
            return base.Channel.datMon(c);
        }
        
        public System.Threading.Tasks.Task<int> datMonAsync(quanlyquancafe.ServiceReference1.coffee c) {
            return base.Channel.datMonAsync(c);
        }
        
        public quanlyquancafe.ServiceReference1.coffee[] Daban() {
            return base.Channel.Daban();
        }
        
        public System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.coffee[]> DabanAsync() {
            return base.Channel.DabanAsync();
        }
        
        public quanlyquancafe.ServiceReference1.coffee[] conlai() {
            return base.Channel.conlai();
        }
        
        public System.Threading.Tasks.Task<quanlyquancafe.ServiceReference1.coffee[]> conlaiAsync() {
            return base.Channel.conlaiAsync();
        }
        
        public decimal doanhthu() {
            return base.Channel.doanhthu();
        }
        
        public System.Threading.Tasks.Task<decimal> doanhthuAsync() {
            return base.Channel.doanhthuAsync();
        }
    }
}
