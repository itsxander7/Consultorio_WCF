﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL.BD_Connection {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BD_Connection.IBD")]
    public interface IBD {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/Get_DT_Param", ReplyAction="http://tempuri.org/IBD/Get_DT_ParamResponse")]
        System.Data.DataTable Get_DT_Param(System.Data.DataTable DT_Param);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/Get_DT_Param", ReplyAction="http://tempuri.org/IBD/Get_DT_ParamResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> Get_DT_ParamAsync(System.Data.DataTable DT_Param);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/ListarFiltrar", ReplyAction="http://tempuri.org/IBD/ListarFiltrarResponse")]
        System.Data.DataTable ListarFiltrar(string sNombreTabla, string sNombreSP, System.Data.DataTable DT_Param);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/ListarFiltrar", ReplyAction="http://tempuri.org/IBD/ListarFiltrarResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> ListarFiltrarAsync(string sNombreTabla, string sNombreSP, System.Data.DataTable DT_Param);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/Ins_Upd_Delete", ReplyAction="http://tempuri.org/IBD/Ins_Upd_DeleteResponse")]
        string Ins_Upd_Delete(string sNombreSP, string sIndAxn, System.Data.DataTable DT_Param);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBD/Ins_Upd_Delete", ReplyAction="http://tempuri.org/IBD/Ins_Upd_DeleteResponse")]
        System.Threading.Tasks.Task<string> Ins_Upd_DeleteAsync(string sNombreSP, string sIndAxn, System.Data.DataTable DT_Param);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBDChannel : BLL.BD_Connection.IBD, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BDClient : System.ServiceModel.ClientBase<BLL.BD_Connection.IBD>, BLL.BD_Connection.IBD {
        
        public BDClient() {
        }
        
        public BDClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BDClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BDClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BDClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable Get_DT_Param(System.Data.DataTable DT_Param) {
            return base.Channel.Get_DT_Param(DT_Param);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> Get_DT_ParamAsync(System.Data.DataTable DT_Param) {
            return base.Channel.Get_DT_ParamAsync(DT_Param);
        }
        
        public System.Data.DataTable ListarFiltrar(string sNombreTabla, string sNombreSP, System.Data.DataTable DT_Param) {
            return base.Channel.ListarFiltrar(sNombreTabla, sNombreSP, DT_Param);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ListarFiltrarAsync(string sNombreTabla, string sNombreSP, System.Data.DataTable DT_Param) {
            return base.Channel.ListarFiltrarAsync(sNombreTabla, sNombreSP, DT_Param);
        }
        
        public string Ins_Upd_Delete(string sNombreSP, string sIndAxn, System.Data.DataTable DT_Param) {
            return base.Channel.Ins_Upd_Delete(sNombreSP, sIndAxn, DT_Param);
        }
        
        public System.Threading.Tasks.Task<string> Ins_Upd_DeleteAsync(string sNombreSP, string sIndAxn, System.Data.DataTable DT_Param) {
            return base.Channel.Ins_Upd_DeleteAsync(sNombreSP, sIndAxn, DT_Param);
        }
    }
}
