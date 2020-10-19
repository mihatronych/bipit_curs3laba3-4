﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace curs3laba4.RefLibrary1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefLibrary1.ServiceForLibrarySoap")]
    public interface ServiceForLibrarySoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetAllData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllData", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDataToOrFrom", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetDataToOrFrom(System.DateTime time, bool from);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDataToOrFrom", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetDataToOrFromAsync(System.DateTime time, bool from);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDataToAndFrom", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetDataToAndFrom(System.DateTime from, System.DateTime to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetDataToAndFrom", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetDataToAndFromAsync(System.DateTime from, System.DateTime to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewRec", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string NewRec(int id, int r_id, int b_id, System.DateTime o_dt_out, System.DateTime o_dt_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/NewRec", ReplyAction="*")]
        System.Threading.Tasks.Task<string> NewRecAsync(int id, int r_id, int b_id, System.DateTime o_dt_out, System.DateTime o_dt_in);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteRec", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string DeleteRec(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DeleteRec", ReplyAction="*")]
        System.Threading.Tasks.Task<string> DeleteRecAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceForLibrarySoapChannel : curs3laba4.RefLibrary1.ServiceForLibrarySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceForLibrarySoapClient : System.ServiceModel.ClientBase<curs3laba4.RefLibrary1.ServiceForLibrarySoap>, curs3laba4.RefLibrary1.ServiceForLibrarySoap {
        
        public ServiceForLibrarySoapClient() {
        }
        
        public ServiceForLibrarySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceForLibrarySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceForLibrarySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceForLibrarySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetAllData() {
            return base.Channel.GetAllData();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllDataAsync() {
            return base.Channel.GetAllDataAsync();
        }
        
        public System.Data.DataSet GetDataToOrFrom(System.DateTime time, bool from) {
            return base.Channel.GetDataToOrFrom(time, from);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetDataToOrFromAsync(System.DateTime time, bool from) {
            return base.Channel.GetDataToOrFromAsync(time, from);
        }
        
        public System.Data.DataSet GetDataToAndFrom(System.DateTime from, System.DateTime to) {
            return base.Channel.GetDataToAndFrom(from, to);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetDataToAndFromAsync(System.DateTime from, System.DateTime to) {
            return base.Channel.GetDataToAndFromAsync(from, to);
        }
        
        public string NewRec(int id, int r_id, int b_id, System.DateTime o_dt_out, System.DateTime o_dt_in) {
            return base.Channel.NewRec(id, r_id, b_id, o_dt_out, o_dt_in);
        }
        
        public System.Threading.Tasks.Task<string> NewRecAsync(int id, int r_id, int b_id, System.DateTime o_dt_out, System.DateTime o_dt_in) {
            return base.Channel.NewRecAsync(id, r_id, b_id, o_dt_out, o_dt_in);
        }
        
        public string DeleteRec(int ID) {
            return base.Channel.DeleteRec(ID);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRecAsync(int ID) {
            return base.Channel.DeleteRecAsync(ID);
        }
    }
}