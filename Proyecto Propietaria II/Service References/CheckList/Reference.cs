﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Propietaria_II.CheckList {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CheckList.CheckListSoap")]
    public interface CheckListSoap {
        
        // CODEGEN: Generating message contract since element name tanda from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TandaDeEstudio", ReplyAction="*")]
        Proyecto_Propietaria_II.CheckList.TandaDeEstudioResponse TandaDeEstudio(Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TandaDeEstudio", ReplyAction="*")]
        System.Threading.Tasks.Task<Proyecto_Propietaria_II.CheckList.TandaDeEstudioResponse> TandaDeEstudioAsync(Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TandaDeEstudioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TandaDeEstudio", Namespace="http://tempuri.org/", Order=0)]
        public Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequestBody Body;
        
        public TandaDeEstudioRequest() {
        }
        
        public TandaDeEstudioRequest(Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TandaDeEstudioRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string tanda;    
        
        public TandaDeEstudioRequestBody() {
        }
        
        public TandaDeEstudioRequestBody(string tanda) {
            this.tanda = tanda;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TandaDeEstudioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TandaDeEstudioResponse", Namespace="http://tempuri.org/", Order=0)]
        public Proyecto_Propietaria_II.CheckList.TandaDeEstudioResponseBody Body;
        
        public TandaDeEstudioResponse() {
        }
        
        public TandaDeEstudioResponse(Proyecto_Propietaria_II.CheckList.TandaDeEstudioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TandaDeEstudioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string TandaDeEstudioResult;
        
        public TandaDeEstudioResponseBody() {
        }
        
        public TandaDeEstudioResponseBody(string TandaDeEstudioResult) {
            this.TandaDeEstudioResult = TandaDeEstudioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CheckListSoapChannel : Proyecto_Propietaria_II.CheckList.CheckListSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CheckListSoapClient : System.ServiceModel.ClientBase<Proyecto_Propietaria_II.CheckList.CheckListSoap>, Proyecto_Propietaria_II.CheckList.CheckListSoap {
        
        public CheckListSoapClient() {
        }
        
        public CheckListSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CheckListSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckListSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckListSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Proyecto_Propietaria_II.CheckList.TandaDeEstudioResponse Proyecto_Propietaria_II.CheckList.CheckListSoap.TandaDeEstudio(Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequest request) {
            return base.Channel.TandaDeEstudio(request);
        }
        
        public string TandaDeEstudio(string tanda) {
            Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequest inValue = new Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequest();
            inValue.Body = new Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequestBody();
            inValue.Body.tanda = tanda;
            Proyecto_Propietaria_II.CheckList.TandaDeEstudioResponse retVal = ((Proyecto_Propietaria_II.CheckList.CheckListSoap)(this)).TandaDeEstudio(inValue);
            return retVal.Body.TandaDeEstudioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Proyecto_Propietaria_II.CheckList.TandaDeEstudioResponse> Proyecto_Propietaria_II.CheckList.CheckListSoap.TandaDeEstudioAsync(Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequest request) {
            return base.Channel.TandaDeEstudioAsync(request);
        }
        
        public System.Threading.Tasks.Task<Proyecto_Propietaria_II.CheckList.TandaDeEstudioResponse> TandaDeEstudioAsync(string tanda) {
            Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequest inValue = new Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequest();
            inValue.Body = new Proyecto_Propietaria_II.CheckList.TandaDeEstudioRequestBody();
            inValue.Body.tanda = tanda;
            return ((Proyecto_Propietaria_II.CheckList.CheckListSoap)(this)).TandaDeEstudioAsync(inValue);
        }
    }
}