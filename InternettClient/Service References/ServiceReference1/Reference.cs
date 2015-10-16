﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternettClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://main", ConfigurationName="ServiceReference1.ServicePortType")]
    public interface ServicePortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ByteCounter", ReplyAction="urn:ByteCounterResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        int ByteCounter();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ByteCounter", ReplyAction="urn:ByteCounterResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<int> ByteCounterAsync();
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:ReturnQRPicture", ReplyAction="urn:ReturnQRPictureResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        InternettClient.ServiceReference1.ReturnQRPictureResponse ReturnQRPicture(InternettClient.ServiceReference1.ReturnQRPictureRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ReturnQRPicture", ReplyAction="urn:ReturnQRPictureResponse")]
        System.Threading.Tasks.Task<InternettClient.ServiceReference1.ReturnQRPictureResponse> ReturnQRPictureAsync(InternettClient.ServiceReference1.ReturnQRPictureRequest request);
        
        // CODEGEN: Parameter 'Username' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:Authenticate", ReplyAction="urn:AuthenticateResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        InternettClient.ServiceReference1.AuthenticateResponse Authenticate(InternettClient.ServiceReference1.AuthenticateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:Authenticate", ReplyAction="urn:AuthenticateResponse")]
        System.Threading.Tasks.Task<InternettClient.ServiceReference1.AuthenticateResponse> AuthenticateAsync(InternettClient.ServiceReference1.AuthenticateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReturnQRPicture", WrapperNamespace="http://main", IsWrapped=true)]
    public partial class ReturnQRPictureRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://main", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Username;
        
        public ReturnQRPictureRequest() {
        }
        
        public ReturnQRPictureRequest(string Username) {
            this.Username = Username;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReturnQRPictureResponse", WrapperNamespace="http://main", IsWrapped=true)]
    public partial class ReturnQRPictureResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://main", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return")]
        public sbyte[] @return;
        
        public ReturnQRPictureResponse() {
        }
        
        public ReturnQRPictureResponse(sbyte[] @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Authenticate", WrapperNamespace="http://main", IsWrapped=true)]
    public partial class AuthenticateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://main", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Username;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://main", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Password;
        
        public AuthenticateRequest() {
        }
        
        public AuthenticateRequest(string Username, string Password) {
            this.Username = Username;
            this.Password = Password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthenticateResponse", WrapperNamespace="http://main", IsWrapped=true)]
    public partial class AuthenticateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://main", Order=0)]
        public bool @return;
        
        public AuthenticateResponse() {
        }
        
        public AuthenticateResponse(bool @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServicePortTypeChannel : InternettClient.ServiceReference1.ServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePortTypeClient : System.ServiceModel.ClientBase<InternettClient.ServiceReference1.ServicePortType>, InternettClient.ServiceReference1.ServicePortType {
        
        public ServicePortTypeClient() {
        }
        
        public ServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int ByteCounter() {
            return base.Channel.ByteCounter();
        }
        
        public System.Threading.Tasks.Task<int> ByteCounterAsync() {
            return base.Channel.ByteCounterAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InternettClient.ServiceReference1.ReturnQRPictureResponse InternettClient.ServiceReference1.ServicePortType.ReturnQRPicture(InternettClient.ServiceReference1.ReturnQRPictureRequest request) {
            return base.Channel.ReturnQRPicture(request);
        }
        
        public sbyte[] ReturnQRPicture(string Username) {
            InternettClient.ServiceReference1.ReturnQRPictureRequest inValue = new InternettClient.ServiceReference1.ReturnQRPictureRequest();
            inValue.Username = Username;
            InternettClient.ServiceReference1.ReturnQRPictureResponse retVal = ((InternettClient.ServiceReference1.ServicePortType)(this)).ReturnQRPicture(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InternettClient.ServiceReference1.ReturnQRPictureResponse> InternettClient.ServiceReference1.ServicePortType.ReturnQRPictureAsync(InternettClient.ServiceReference1.ReturnQRPictureRequest request) {
            return base.Channel.ReturnQRPictureAsync(request);
        }
        
        public System.Threading.Tasks.Task<InternettClient.ServiceReference1.ReturnQRPictureResponse> ReturnQRPictureAsync(string Username) {
            InternettClient.ServiceReference1.ReturnQRPictureRequest inValue = new InternettClient.ServiceReference1.ReturnQRPictureRequest();
            inValue.Username = Username;
            return ((InternettClient.ServiceReference1.ServicePortType)(this)).ReturnQRPictureAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InternettClient.ServiceReference1.AuthenticateResponse InternettClient.ServiceReference1.ServicePortType.Authenticate(InternettClient.ServiceReference1.AuthenticateRequest request) {
            return base.Channel.Authenticate(request);
        }
        
        public bool Authenticate(string Username, string Password) {
            InternettClient.ServiceReference1.AuthenticateRequest inValue = new InternettClient.ServiceReference1.AuthenticateRequest();
            inValue.Username = Username;
            inValue.Password = Password;
            InternettClient.ServiceReference1.AuthenticateResponse retVal = ((InternettClient.ServiceReference1.ServicePortType)(this)).Authenticate(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InternettClient.ServiceReference1.AuthenticateResponse> InternettClient.ServiceReference1.ServicePortType.AuthenticateAsync(InternettClient.ServiceReference1.AuthenticateRequest request) {
            return base.Channel.AuthenticateAsync(request);
        }
        
        public System.Threading.Tasks.Task<InternettClient.ServiceReference1.AuthenticateResponse> AuthenticateAsync(string Username, string Password) {
            InternettClient.ServiceReference1.AuthenticateRequest inValue = new InternettClient.ServiceReference1.AuthenticateRequest();
            inValue.Username = Username;
            inValue.Password = Password;
            return ((InternettClient.ServiceReference1.ServicePortType)(this)).AuthenticateAsync(inValue);
        }
    }
}
