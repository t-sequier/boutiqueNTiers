﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppClient.Webservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CPays", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CPays : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CRegions", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class CRegions : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Webservice.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément nom de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        AppClient.Webservice.HelloWorldResponse HelloWorld(AppClient.Webservice.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.IAsyncResult BeginHelloWorld(AppClient.Webservice.HelloWorldRequest request, System.AsyncCallback callback, object asyncState);
        
        AppClient.Webservice.HelloWorldResponse EndHelloWorld(System.IAsyncResult result);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément getTousLesPaysResult de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getTousLesPays", ReplyAction="*")]
        AppClient.Webservice.getTousLesPaysResponse getTousLesPays(AppClient.Webservice.getTousLesPaysRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/getTousLesPays", ReplyAction="*")]
        System.IAsyncResult BegingetTousLesPays(AppClient.Webservice.getTousLesPaysRequest request, System.AsyncCallback callback, object asyncState);
        
        AppClient.Webservice.getTousLesPaysResponse EndgetTousLesPays(System.IAsyncResult result);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément getToutesLesRegionsResult de l'espace de noms http://tempuri.org/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getToutesLesRegions", ReplyAction="*")]
        AppClient.Webservice.getToutesLesRegionsResponse getToutesLesRegions(AppClient.Webservice.getToutesLesRegionsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/getToutesLesRegions", ReplyAction="*")]
        System.IAsyncResult BegingetToutesLesRegions(AppClient.Webservice.getToutesLesRegionsRequest request, System.AsyncCallback callback, object asyncState);
        
        AppClient.Webservice.getToutesLesRegionsResponse EndgetToutesLesRegions(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public AppClient.Webservice.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(AppClient.Webservice.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nom;
        
        public HelloWorldRequestBody() {
        }
        
        public HelloWorldRequestBody(string nom) {
            this.nom = nom;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public AppClient.Webservice.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(AppClient.Webservice.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getTousLesPaysRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getTousLesPays", Namespace="http://tempuri.org/", Order=0)]
        public AppClient.Webservice.getTousLesPaysRequestBody Body;
        
        public getTousLesPaysRequest() {
        }
        
        public getTousLesPaysRequest(AppClient.Webservice.getTousLesPaysRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class getTousLesPaysRequestBody {
        
        public getTousLesPaysRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getTousLesPaysResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getTousLesPaysResponse", Namespace="http://tempuri.org/", Order=0)]
        public AppClient.Webservice.getTousLesPaysResponseBody Body;
        
        public getTousLesPaysResponse() {
        }
        
        public getTousLesPaysResponse(AppClient.Webservice.getTousLesPaysResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getTousLesPaysResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AppClient.Webservice.CPays[] getTousLesPaysResult;
        
        public getTousLesPaysResponseBody() {
        }
        
        public getTousLesPaysResponseBody(AppClient.Webservice.CPays[] getTousLesPaysResult) {
            this.getTousLesPaysResult = getTousLesPaysResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getToutesLesRegionsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getToutesLesRegions", Namespace="http://tempuri.org/", Order=0)]
        public AppClient.Webservice.getToutesLesRegionsRequestBody Body;
        
        public getToutesLesRegionsRequest() {
        }
        
        public getToutesLesRegionsRequest(AppClient.Webservice.getToutesLesRegionsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getToutesLesRegionsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int idPays;
        
        public getToutesLesRegionsRequestBody() {
        }
        
        public getToutesLesRegionsRequestBody(int idPays) {
            this.idPays = idPays;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getToutesLesRegionsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getToutesLesRegionsResponse", Namespace="http://tempuri.org/", Order=0)]
        public AppClient.Webservice.getToutesLesRegionsResponseBody Body;
        
        public getToutesLesRegionsResponse() {
        }
        
        public getToutesLesRegionsResponse(AppClient.Webservice.getToutesLesRegionsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getToutesLesRegionsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public AppClient.Webservice.CRegions[] getToutesLesRegionsResult;
        
        public getToutesLesRegionsResponseBody() {
        }
        
        public getToutesLesRegionsResponseBody(AppClient.Webservice.CRegions[] getToutesLesRegionsResult) {
            this.getToutesLesRegionsResult = getToutesLesRegionsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : AppClient.Webservice.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getTousLesPaysCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getTousLesPaysCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AppClient.Webservice.CPays[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((AppClient.Webservice.CPays[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getToutesLesRegionsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getToutesLesRegionsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public AppClient.Webservice.CRegions[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((AppClient.Webservice.CRegions[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<AppClient.Webservice.WebServiceSoap>, AppClient.Webservice.WebServiceSoap {
        
        private BeginOperationDelegate onBeginHelloWorldDelegate;
        
        private EndOperationDelegate onEndHelloWorldDelegate;
        
        private System.Threading.SendOrPostCallback onHelloWorldCompletedDelegate;
        
        private BeginOperationDelegate onBegingetTousLesPaysDelegate;
        
        private EndOperationDelegate onEndgetTousLesPaysDelegate;
        
        private System.Threading.SendOrPostCallback ongetTousLesPaysCompletedDelegate;
        
        private BeginOperationDelegate onBegingetToutesLesRegionsDelegate;
        
        private EndOperationDelegate onEndgetToutesLesRegionsDelegate;
        
        private System.Threading.SendOrPostCallback ongetToutesLesRegionsCompletedDelegate;
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<HelloWorldCompletedEventArgs> HelloWorldCompleted;
        
        public event System.EventHandler<getTousLesPaysCompletedEventArgs> getTousLesPaysCompleted;
        
        public event System.EventHandler<getToutesLesRegionsCompletedEventArgs> getToutesLesRegionsCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AppClient.Webservice.HelloWorldResponse AppClient.Webservice.WebServiceSoap.HelloWorld(AppClient.Webservice.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld(string nom) {
            AppClient.Webservice.HelloWorldRequest inValue = new AppClient.Webservice.HelloWorldRequest();
            inValue.Body = new AppClient.Webservice.HelloWorldRequestBody();
            inValue.Body.nom = nom;
            AppClient.Webservice.HelloWorldResponse retVal = ((AppClient.Webservice.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AppClient.Webservice.WebServiceSoap.BeginHelloWorld(AppClient.Webservice.HelloWorldRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginHelloWorld(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginHelloWorld(string nom, System.AsyncCallback callback, object asyncState) {
            AppClient.Webservice.HelloWorldRequest inValue = new AppClient.Webservice.HelloWorldRequest();
            inValue.Body = new AppClient.Webservice.HelloWorldRequestBody();
            inValue.Body.nom = nom;
            return ((AppClient.Webservice.WebServiceSoap)(this)).BeginHelloWorld(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AppClient.Webservice.HelloWorldResponse AppClient.Webservice.WebServiceSoap.EndHelloWorld(System.IAsyncResult result) {
            return base.Channel.EndHelloWorld(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndHelloWorld(System.IAsyncResult result) {
            AppClient.Webservice.HelloWorldResponse retVal = ((AppClient.Webservice.WebServiceSoap)(this)).EndHelloWorld(result);
            return retVal.Body.HelloWorldResult;
        }
        
        private System.IAsyncResult OnBeginHelloWorld(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string nom = ((string)(inValues[0]));
            return this.BeginHelloWorld(nom, callback, asyncState);
        }
        
        private object[] OnEndHelloWorld(System.IAsyncResult result) {
            string retVal = this.EndHelloWorld(result);
            return new object[] {
                    retVal};
        }
        
        private void OnHelloWorldCompleted(object state) {
            if ((this.HelloWorldCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void HelloWorldAsync(string nom) {
            this.HelloWorldAsync(nom, null);
        }
        
        public void HelloWorldAsync(string nom, object userState) {
            if ((this.onBeginHelloWorldDelegate == null)) {
                this.onBeginHelloWorldDelegate = new BeginOperationDelegate(this.OnBeginHelloWorld);
            }
            if ((this.onEndHelloWorldDelegate == null)) {
                this.onEndHelloWorldDelegate = new EndOperationDelegate(this.OnEndHelloWorld);
            }
            if ((this.onHelloWorldCompletedDelegate == null)) {
                this.onHelloWorldCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnHelloWorldCompleted);
            }
            base.InvokeAsync(this.onBeginHelloWorldDelegate, new object[] {
                        nom}, this.onEndHelloWorldDelegate, this.onHelloWorldCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AppClient.Webservice.getTousLesPaysResponse AppClient.Webservice.WebServiceSoap.getTousLesPays(AppClient.Webservice.getTousLesPaysRequest request) {
            return base.Channel.getTousLesPays(request);
        }
        
        public AppClient.Webservice.CPays[] getTousLesPays() {
            AppClient.Webservice.getTousLesPaysRequest inValue = new AppClient.Webservice.getTousLesPaysRequest();
            inValue.Body = new AppClient.Webservice.getTousLesPaysRequestBody();
            AppClient.Webservice.getTousLesPaysResponse retVal = ((AppClient.Webservice.WebServiceSoap)(this)).getTousLesPays(inValue);
            return retVal.Body.getTousLesPaysResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AppClient.Webservice.WebServiceSoap.BegingetTousLesPays(AppClient.Webservice.getTousLesPaysRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetTousLesPays(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetTousLesPays(System.AsyncCallback callback, object asyncState) {
            AppClient.Webservice.getTousLesPaysRequest inValue = new AppClient.Webservice.getTousLesPaysRequest();
            inValue.Body = new AppClient.Webservice.getTousLesPaysRequestBody();
            return ((AppClient.Webservice.WebServiceSoap)(this)).BegingetTousLesPays(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AppClient.Webservice.getTousLesPaysResponse AppClient.Webservice.WebServiceSoap.EndgetTousLesPays(System.IAsyncResult result) {
            return base.Channel.EndgetTousLesPays(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public AppClient.Webservice.CPays[] EndgetTousLesPays(System.IAsyncResult result) {
            AppClient.Webservice.getTousLesPaysResponse retVal = ((AppClient.Webservice.WebServiceSoap)(this)).EndgetTousLesPays(result);
            return retVal.Body.getTousLesPaysResult;
        }
        
        private System.IAsyncResult OnBegingetTousLesPays(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BegingetTousLesPays(callback, asyncState);
        }
        
        private object[] OnEndgetTousLesPays(System.IAsyncResult result) {
            AppClient.Webservice.CPays[] retVal = this.EndgetTousLesPays(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetTousLesPaysCompleted(object state) {
            if ((this.getTousLesPaysCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getTousLesPaysCompleted(this, new getTousLesPaysCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getTousLesPaysAsync() {
            this.getTousLesPaysAsync(null);
        }
        
        public void getTousLesPaysAsync(object userState) {
            if ((this.onBegingetTousLesPaysDelegate == null)) {
                this.onBegingetTousLesPaysDelegate = new BeginOperationDelegate(this.OnBegingetTousLesPays);
            }
            if ((this.onEndgetTousLesPaysDelegate == null)) {
                this.onEndgetTousLesPaysDelegate = new EndOperationDelegate(this.OnEndgetTousLesPays);
            }
            if ((this.ongetTousLesPaysCompletedDelegate == null)) {
                this.ongetTousLesPaysCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetTousLesPaysCompleted);
            }
            base.InvokeAsync(this.onBegingetTousLesPaysDelegate, null, this.onEndgetTousLesPaysDelegate, this.ongetTousLesPaysCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AppClient.Webservice.getToutesLesRegionsResponse AppClient.Webservice.WebServiceSoap.getToutesLesRegions(AppClient.Webservice.getToutesLesRegionsRequest request) {
            return base.Channel.getToutesLesRegions(request);
        }
        
        public AppClient.Webservice.CRegions[] getToutesLesRegions(int idPays) {
            AppClient.Webservice.getToutesLesRegionsRequest inValue = new AppClient.Webservice.getToutesLesRegionsRequest();
            inValue.Body = new AppClient.Webservice.getToutesLesRegionsRequestBody();
            inValue.Body.idPays = idPays;
            AppClient.Webservice.getToutesLesRegionsResponse retVal = ((AppClient.Webservice.WebServiceSoap)(this)).getToutesLesRegions(inValue);
            return retVal.Body.getToutesLesRegionsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult AppClient.Webservice.WebServiceSoap.BegingetToutesLesRegions(AppClient.Webservice.getToutesLesRegionsRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetToutesLesRegions(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetToutesLesRegions(int idPays, System.AsyncCallback callback, object asyncState) {
            AppClient.Webservice.getToutesLesRegionsRequest inValue = new AppClient.Webservice.getToutesLesRegionsRequest();
            inValue.Body = new AppClient.Webservice.getToutesLesRegionsRequestBody();
            inValue.Body.idPays = idPays;
            return ((AppClient.Webservice.WebServiceSoap)(this)).BegingetToutesLesRegions(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        AppClient.Webservice.getToutesLesRegionsResponse AppClient.Webservice.WebServiceSoap.EndgetToutesLesRegions(System.IAsyncResult result) {
            return base.Channel.EndgetToutesLesRegions(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public AppClient.Webservice.CRegions[] EndgetToutesLesRegions(System.IAsyncResult result) {
            AppClient.Webservice.getToutesLesRegionsResponse retVal = ((AppClient.Webservice.WebServiceSoap)(this)).EndgetToutesLesRegions(result);
            return retVal.Body.getToutesLesRegionsResult;
        }
        
        private System.IAsyncResult OnBegingetToutesLesRegions(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int idPays = ((int)(inValues[0]));
            return this.BegingetToutesLesRegions(idPays, callback, asyncState);
        }
        
        private object[] OnEndgetToutesLesRegions(System.IAsyncResult result) {
            AppClient.Webservice.CRegions[] retVal = this.EndgetToutesLesRegions(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetToutesLesRegionsCompleted(object state) {
            if ((this.getToutesLesRegionsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getToutesLesRegionsCompleted(this, new getToutesLesRegionsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getToutesLesRegionsAsync(int idPays) {
            this.getToutesLesRegionsAsync(idPays, null);
        }
        
        public void getToutesLesRegionsAsync(int idPays, object userState) {
            if ((this.onBegingetToutesLesRegionsDelegate == null)) {
                this.onBegingetToutesLesRegionsDelegate = new BeginOperationDelegate(this.OnBegingetToutesLesRegions);
            }
            if ((this.onEndgetToutesLesRegionsDelegate == null)) {
                this.onEndgetToutesLesRegionsDelegate = new EndOperationDelegate(this.OnEndgetToutesLesRegions);
            }
            if ((this.ongetToutesLesRegionsCompletedDelegate == null)) {
                this.ongetToutesLesRegionsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetToutesLesRegionsCompleted);
            }
            base.InvokeAsync(this.onBegingetToutesLesRegionsDelegate, new object[] {
                        idPays}, this.onEndgetToutesLesRegionsDelegate, this.ongetToutesLesRegionsCompletedDelegate, userState);
        }
    }
}
