//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab7bClient.WCFService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Phone", Namespace="http://schemas.datacontract.org/2004/07/PhoneDictionaryServiceLibrary.Models")]
    [System.SerializableAttribute()]
    public partial class Phone : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Phone_numberField;
        
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
        public int Id {
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone_number {
            get {
                return this.Phone_numberField;
            }
            set {
                if ((object.ReferenceEquals(this.Phone_numberField, value) != true)) {
                    this.Phone_numberField = value;
                    this.RaisePropertyChanged("Phone_number");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDict", ReplyAction="http://tempuri.org/IService1/GetDictResponse")]
        lab7bClient.WCFService.Phone[] GetDict();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDict", ReplyAction="http://tempuri.org/IService1/GetDictResponse")]
        System.Threading.Tasks.Task<lab7bClient.WCFService.Phone[]> GetDictAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddDict", ReplyAction="http://tempuri.org/IService1/AddDictResponse")]
        void AddDict(lab7bClient.WCFService.Phone person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddDict", ReplyAction="http://tempuri.org/IService1/AddDictResponse")]
        System.Threading.Tasks.Task AddDictAsync(lab7bClient.WCFService.Phone person);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdDict", ReplyAction="http://tempuri.org/IService1/UpdDictResponse")]
        void UpdDict(lab7bClient.WCFService.Phone phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdDict", ReplyAction="http://tempuri.org/IService1/UpdDictResponse")]
        System.Threading.Tasks.Task UpdDictAsync(lab7bClient.WCFService.Phone phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DelDict", ReplyAction="http://tempuri.org/IService1/DelDictResponse")]
        void DelDict(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DelDict", ReplyAction="http://tempuri.org/IService1/DelDictResponse")]
        System.Threading.Tasks.Task DelDictAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : lab7bClient.WCFService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<lab7bClient.WCFService.IService1>, lab7bClient.WCFService.IService1 {
        
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
        
        public lab7bClient.WCFService.Phone[] GetDict() {
            return base.Channel.GetDict();
        }
        
        public System.Threading.Tasks.Task<lab7bClient.WCFService.Phone[]> GetDictAsync() {
            return base.Channel.GetDictAsync();
        }
        
        public void AddDict(lab7bClient.WCFService.Phone person) {
            base.Channel.AddDict(person);
        }
        
        public System.Threading.Tasks.Task AddDictAsync(lab7bClient.WCFService.Phone person) {
            return base.Channel.AddDictAsync(person);
        }
        
        public void UpdDict(lab7bClient.WCFService.Phone phone) {
            base.Channel.UpdDict(phone);
        }
        
        public System.Threading.Tasks.Task UpdDictAsync(lab7bClient.WCFService.Phone phone) {
            return base.Channel.UpdDictAsync(phone);
        }
        
        public void DelDict(int id) {
            base.Channel.DelDict(id);
        }
        
        public System.Threading.Tasks.Task DelDictAsync(int id) {
            return base.Channel.DelDictAsync(id);
        }
    }
}
