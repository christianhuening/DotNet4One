// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Terradue.OpenNebula {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://opennebula.org/XMLSchema", IsNullable=false)]
    public partial class VNET_POOL {
        
        private VNET[] vNETField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VNET")]
        public VNET[] VNET {
            get {
                return this.vNETField;
            }
            set {
                this.vNETField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://opennebula.org/XMLSchema", IsNullable=true)]
    public partial class VNET {
        
        private string iDField;
        
        private string uIDField;
        
        private string gIDField;
        
        private string uNAMEField;
        
        private string gNAMEField;
        
        private string nAMEField;
        
        private VNETPERMISSIONS pERMISSIONSField;
        
        private string cLUSTER_IDField;
        
        private string cLUSTERField;
        
        private string tYPEField;
        
        private string bRIDGEField;
        
        private string vLANField;
        
        private string pHYDEVField;
        
        private string vLAN_IDField;
        
        private string gLOBAL_PREFIXField;
        
        private string sITE_PREFIXField;
        
        private VNETRANGE rANGEField;
        
        private string tOTAL_LEASESField;
        
        private object tEMPLATEField;
        
        private VNETLEASESLEASE[] lEASESField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string ID {
            get {
                return this.iDField;
            }
            set {
                this.iDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string UID {
            get {
                return this.uIDField;
            }
            set {
                this.uIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string GID {
            get {
                return this.gIDField;
            }
            set {
                this.gIDField = value;
            }
        }
        
        /// <remarks/>
        public string UNAME {
            get {
                return this.uNAMEField;
            }
            set {
                this.uNAMEField = value;
            }
        }
        
        /// <remarks/>
        public string GNAME {
            get {
                return this.gNAMEField;
            }
            set {
                this.gNAMEField = value;
            }
        }
        
        /// <remarks/>
        public string NAME {
            get {
                return this.nAMEField;
            }
            set {
                this.nAMEField = value;
            }
        }
        
        /// <remarks/>
        public VNETPERMISSIONS PERMISSIONS {
            get {
                return this.pERMISSIONSField;
            }
            set {
                this.pERMISSIONSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string CLUSTER_ID {
            get {
                return this.cLUSTER_IDField;
            }
            set {
                this.cLUSTER_IDField = value;
            }
        }
        
        /// <remarks/>
        public string CLUSTER {
            get {
                return this.cLUSTERField;
            }
            set {
                this.cLUSTERField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TYPE {
            get {
                return this.tYPEField;
            }
            set {
                this.tYPEField = value;
            }
        }
        
        /// <remarks/>
        public string BRIDGE {
            get {
                return this.bRIDGEField;
            }
            set {
                this.bRIDGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string VLAN {
            get {
                return this.vLANField;
            }
            set {
                this.vLANField = value;
            }
        }
        
        /// <remarks/>
        public string PHYDEV {
            get {
                return this.pHYDEVField;
            }
            set {
                this.pHYDEVField = value;
            }
        }
        
        /// <remarks/>
        public string VLAN_ID {
            get {
                return this.vLAN_IDField;
            }
            set {
                this.vLAN_IDField = value;
            }
        }
        
        /// <remarks/>
        public string GLOBAL_PREFIX {
            get {
                return this.gLOBAL_PREFIXField;
            }
            set {
                this.gLOBAL_PREFIXField = value;
            }
        }
        
        /// <remarks/>
        public string SITE_PREFIX {
            get {
                return this.sITE_PREFIXField;
            }
            set {
                this.sITE_PREFIXField = value;
            }
        }
        
        /// <remarks/>
        public VNETRANGE RANGE {
            get {
                return this.rANGEField;
            }
            set {
                this.rANGEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string TOTAL_LEASES {
            get {
                return this.tOTAL_LEASESField;
            }
            set {
                this.tOTAL_LEASESField = value;
            }
        }
        
        /// <remarks/>
        public object TEMPLATE {
            get {
                return this.tEMPLATEField;
            }
            set {
                this.tEMPLATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItem(ElementName="LEASE", IsNullable=false)]
        public VNETLEASESLEASE[] LEASES {
            get {
                return this.lEASESField;
            }
            set {
                this.lEASESField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    public partial class VNETPERMISSIONS {
        
        private string oWNER_UField;
        
        private string oWNER_MField;
        
        private string oWNER_AField;
        
        private string gROUP_UField;
        
        private string gROUP_MField;
        
        private string gROUP_AField;
        
        private string oTHER_UField;
        
        private string oTHER_MField;
        
        private string oTHER_AField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string OWNER_U {
            get {
                return this.oWNER_UField;
            }
            set {
                this.oWNER_UField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string OWNER_M {
            get {
                return this.oWNER_MField;
            }
            set {
                this.oWNER_MField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string OWNER_A {
            get {
                return this.oWNER_AField;
            }
            set {
                this.oWNER_AField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string GROUP_U {
            get {
                return this.gROUP_UField;
            }
            set {
                this.gROUP_UField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string GROUP_M {
            get {
                return this.gROUP_MField;
            }
            set {
                this.gROUP_MField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string GROUP_A {
            get {
                return this.gROUP_AField;
            }
            set {
                this.gROUP_AField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string OTHER_U {
            get {
                return this.oTHER_UField;
            }
            set {
                this.oTHER_UField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string OTHER_M {
            get {
                return this.oTHER_MField;
            }
            set {
                this.oTHER_MField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string OTHER_A {
            get {
                return this.oTHER_AField;
            }
            set {
                this.oTHER_AField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    public partial class VNETRANGE {
        
        private string iP_STARTField;
        
        private string iP_ENDField;
        
        /// <remarks/>
        public string IP_START {
            get {
                return this.iP_STARTField;
            }
            set {
                this.iP_STARTField = value;
            }
        }
        
        /// <remarks/>
        public string IP_END {
            get {
                return this.iP_ENDField;
            }
            set {
                this.iP_ENDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://opennebula.org/XMLSchema")]
    public partial class VNETLEASESLEASE {
        
        private string mACField;
        
        private string iPField;
        
        private string iP6_LINKField;
        
        private string iP6_SITEField;
        
        private string iP6_GLOBALField;
        
        private string uSEDField;
        
        private string vIDField;
        
        /// <remarks/>
        public string MAC {
            get {
                return this.mACField;
            }
            set {
                this.mACField = value;
            }
        }
        
        /// <remarks/>
        public string IP {
            get {
                return this.iPField;
            }
            set {
                this.iPField = value;
            }
        }
        
        /// <remarks/>
        public string IP6_LINK {
            get {
                return this.iP6_LINKField;
            }
            set {
                this.iP6_LINKField = value;
            }
        }
        
        /// <remarks/>
        public string IP6_SITE {
            get {
                return this.iP6_SITEField;
            }
            set {
                this.iP6_SITEField = value;
            }
        }
        
        /// <remarks/>
        public string IP6_GLOBAL {
            get {
                return this.iP6_GLOBALField;
            }
            set {
                this.iP6_GLOBALField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string USED {
            get {
                return this.uSEDField;
            }
            set {
                this.uSEDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string VID {
            get {
                return this.vIDField;
            }
            set {
                this.vIDField = value;
            }
        }
    }
}