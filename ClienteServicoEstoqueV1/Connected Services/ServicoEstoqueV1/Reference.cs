﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteServicoEstoqueV1.ServicoEstoqueV1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProdutoTO", Namespace="http://schemas.datacontract.org/2004/07/ProdutosV1")]
    [System.SerializableAttribute()]
    public partial class ProdutoTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstoqueProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumeroProdutoField;
        
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
        public string DescricaoProduto {
            get {
                return this.DescricaoProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoProdutoField, value) != true)) {
                    this.DescricaoProdutoField = value;
                    this.RaisePropertyChanged("DescricaoProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstoqueProduto {
            get {
                return this.EstoqueProdutoField;
            }
            set {
                if ((this.EstoqueProdutoField.Equals(value) != true)) {
                    this.EstoqueProdutoField = value;
                    this.RaisePropertyChanged("EstoqueProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NumeroProduto {
            get {
                return this.NumeroProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NumeroProdutoField, value) != true)) {
                    this.NumeroProdutoField = value;
                    this.RaisePropertyChanged("NumeroProduto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicoEstoqueV1.IServicoEstoqueV1")]
    public interface IServicoEstoqueV1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/ListarProdutos", ReplyAction="http://tempuri.org/IServicoEstoqueV1/ListarProdutosResponse")]
        string[] ListarProdutos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/ListarProdutos", ReplyAction="http://tempuri.org/IServicoEstoqueV1/ListarProdutosResponse")]
        System.Threading.Tasks.Task<string[]> ListarProdutosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/IncluirProduto", ReplyAction="http://tempuri.org/IServicoEstoqueV1/IncluirProdutoResponse")]
        bool IncluirProduto(ClienteServicoEstoqueV1.ServicoEstoqueV1.ProdutoTO ProdutoTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/IncluirProduto", ReplyAction="http://tempuri.org/IServicoEstoqueV1/IncluirProdutoResponse")]
        System.Threading.Tasks.Task<bool> IncluirProdutoAsync(ClienteServicoEstoqueV1.ServicoEstoqueV1.ProdutoTO ProdutoTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/RemoverProduto", ReplyAction="http://tempuri.org/IServicoEstoqueV1/RemoverProdutoResponse")]
        bool RemoverProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/RemoverProduto", ReplyAction="http://tempuri.org/IServicoEstoqueV1/RemoverProdutoResponse")]
        System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/ConsultarEstoque", ReplyAction="http://tempuri.org/IServicoEstoqueV1/ConsultarEstoqueResponse")]
        int ConsultarEstoque(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/ConsultarEstoque", ReplyAction="http://tempuri.org/IServicoEstoqueV1/ConsultarEstoqueResponse")]
        System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/AdcionarEstoque", ReplyAction="http://tempuri.org/IServicoEstoqueV1/AdcionarEstoqueResponse")]
        bool AdcionarEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/AdcionarEstoque", ReplyAction="http://tempuri.org/IServicoEstoqueV1/AdcionarEstoqueResponse")]
        System.Threading.Tasks.Task<bool> AdcionarEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/RemoverEstoque", ReplyAction="http://tempuri.org/IServicoEstoqueV1/RemoverEstoqueResponse")]
        bool RemoverEstoque(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/RemoverEstoque", ReplyAction="http://tempuri.org/IServicoEstoqueV1/RemoverEstoqueResponse")]
        System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/VerProduto", ReplyAction="http://tempuri.org/IServicoEstoqueV1/VerProdutoResponse")]
        ClienteServicoEstoqueV1.ServicoEstoqueV1.ProdutoTO VerProduto(string NumeroProduto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicoEstoqueV1/VerProduto", ReplyAction="http://tempuri.org/IServicoEstoqueV1/VerProdutoResponse")]
        System.Threading.Tasks.Task<ClienteServicoEstoqueV1.ServicoEstoqueV1.ProdutoTO> VerProdutoAsync(string NumeroProduto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicoEstoqueV1Channel : ClienteServicoEstoqueV1.ServicoEstoqueV1.IServicoEstoqueV1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicoEstoqueV1Client : System.ServiceModel.ClientBase<ClienteServicoEstoqueV1.ServicoEstoqueV1.IServicoEstoqueV1>, ClienteServicoEstoqueV1.ServicoEstoqueV1.IServicoEstoqueV1 {
        
        public ServicoEstoqueV1Client() {
        }
        
        public ServicoEstoqueV1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicoEstoqueV1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueV1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicoEstoqueV1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ListarProdutos() {
            return base.Channel.ListarProdutos();
        }
        
        public System.Threading.Tasks.Task<string[]> ListarProdutosAsync() {
            return base.Channel.ListarProdutosAsync();
        }
        
        public bool IncluirProduto(ClienteServicoEstoqueV1.ServicoEstoqueV1.ProdutoTO ProdutoTO) {
            return base.Channel.IncluirProduto(ProdutoTO);
        }
        
        public System.Threading.Tasks.Task<bool> IncluirProdutoAsync(ClienteServicoEstoqueV1.ServicoEstoqueV1.ProdutoTO ProdutoTO) {
            return base.Channel.IncluirProdutoAsync(ProdutoTO);
        }
        
        public bool RemoverProduto(string NumeroProduto) {
            return base.Channel.RemoverProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverProdutoAsync(string NumeroProduto) {
            return base.Channel.RemoverProdutoAsync(NumeroProduto);
        }
        
        public int ConsultarEstoque(string NumeroProduto) {
            return base.Channel.ConsultarEstoque(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<int> ConsultarEstoqueAsync(string NumeroProduto) {
            return base.Channel.ConsultarEstoqueAsync(NumeroProduto);
        }
        
        public bool AdcionarEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.AdcionarEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> AdcionarEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.AdcionarEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public bool RemoverEstoque(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoque(NumeroProduto, Quantidade);
        }
        
        public System.Threading.Tasks.Task<bool> RemoverEstoqueAsync(string NumeroProduto, int Quantidade) {
            return base.Channel.RemoverEstoqueAsync(NumeroProduto, Quantidade);
        }
        
        public ClienteServicoEstoqueV1.ServicoEstoqueV1.ProdutoTO VerProduto(string NumeroProduto) {
            return base.Channel.VerProduto(NumeroProduto);
        }
        
        public System.Threading.Tasks.Task<ClienteServicoEstoqueV1.ServicoEstoqueV1.ProdutoTO> VerProdutoAsync(string NumeroProduto) {
            return base.Channel.VerProdutoAsync(NumeroProduto);
        }
    }
}
