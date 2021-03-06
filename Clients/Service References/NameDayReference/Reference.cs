﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clients.NameDayReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NameDayReference.NameDaySoap")]
    public interface NameDaySoap {
        
        // CODEGEN: Generating message contract since element name inputname from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InputNameReturnDate", ReplyAction="*")]
        Clients.NameDayReference.InputNameReturnDateResponse InputNameReturnDate(Clients.NameDayReference.InputNameReturnDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InputNameReturnDate", ReplyAction="*")]
        System.Threading.Tasks.Task<Clients.NameDayReference.InputNameReturnDateResponse> InputNameReturnDateAsync(Clients.NameDayReference.InputNameReturnDateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InputNameReturnDateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InputNameReturnDate", Namespace="http://tempuri.org/", Order=0)]
        public Clients.NameDayReference.InputNameReturnDateRequestBody Body;
        
        public InputNameReturnDateRequest() {
        }
        
        public InputNameReturnDateRequest(Clients.NameDayReference.InputNameReturnDateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InputNameReturnDateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string inputname;
        
        public InputNameReturnDateRequestBody() {
        }
        
        public InputNameReturnDateRequestBody(string inputname) {
            this.inputname = inputname;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InputNameReturnDateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InputNameReturnDateResponse", Namespace="http://tempuri.org/", Order=0)]
        public Clients.NameDayReference.InputNameReturnDateResponseBody Body;
        
        public InputNameReturnDateResponse() {
        }
        
        public InputNameReturnDateResponse(Clients.NameDayReference.InputNameReturnDateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InputNameReturnDateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string InputNameReturnDateResult;
        
        public InputNameReturnDateResponseBody() {
        }
        
        public InputNameReturnDateResponseBody(string InputNameReturnDateResult) {
            this.InputNameReturnDateResult = InputNameReturnDateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NameDaySoapChannel : Clients.NameDayReference.NameDaySoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NameDaySoapClient : System.ServiceModel.ClientBase<Clients.NameDayReference.NameDaySoap>, Clients.NameDayReference.NameDaySoap {
        
        public NameDaySoapClient() {
        }
        
        public NameDaySoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NameDaySoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameDaySoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NameDaySoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Clients.NameDayReference.InputNameReturnDateResponse Clients.NameDayReference.NameDaySoap.InputNameReturnDate(Clients.NameDayReference.InputNameReturnDateRequest request) {
            return base.Channel.InputNameReturnDate(request);
        }
        
        public string InputNameReturnDate(string inputname) {
            Clients.NameDayReference.InputNameReturnDateRequest inValue = new Clients.NameDayReference.InputNameReturnDateRequest();
            inValue.Body = new Clients.NameDayReference.InputNameReturnDateRequestBody();
            inValue.Body.inputname = inputname;
            Clients.NameDayReference.InputNameReturnDateResponse retVal = ((Clients.NameDayReference.NameDaySoap)(this)).InputNameReturnDate(inValue);
            return retVal.Body.InputNameReturnDateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Clients.NameDayReference.InputNameReturnDateResponse> Clients.NameDayReference.NameDaySoap.InputNameReturnDateAsync(Clients.NameDayReference.InputNameReturnDateRequest request) {
            return base.Channel.InputNameReturnDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Clients.NameDayReference.InputNameReturnDateResponse> InputNameReturnDateAsync(string inputname) {
            Clients.NameDayReference.InputNameReturnDateRequest inValue = new Clients.NameDayReference.InputNameReturnDateRequest();
            inValue.Body = new Clients.NameDayReference.InputNameReturnDateRequestBody();
            inValue.Body.inputname = inputname;
            return ((Clients.NameDayReference.NameDaySoap)(this)).InputNameReturnDateAsync(inValue);
        }
    }
}
