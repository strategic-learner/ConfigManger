using System;
using System.Collections;


namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// this object is the base JPlanLOB entity plus PlanAbbr & LOBAbbr
    /// </summary>

    public class ConfigParamConsolidated : IConfigParamConsolidated
        {
        public ConfigParamConsolidated() { }
        public ConfigParamConsolidated(
            string Environ
            , Guid _ID
            , Guid _ConfigID
            , DateTime _effDT
            , DateTime _trmDT
            , Guid _ParamDefinitionID
            , bool _isRefOnly
            , string _value
            , string _valueUseageComments
            )
            {
            this.Environ = Environ;
            this.ID = _ID;
            this.ConfigID = _ConfigID;
            this.effDT = _effDT;
            this.trmDT = _trmDT;
            this.ParamDefinitionID = _ParamDefinitionID;
            this.isRefOnly = _isRefOnly;
            this.value = _value;
            this.valueUseageComments = _valueUseageComments;
            }


        public Guid ID { get;  set; }
        public DateTime updateDT { get; set; }
        public string updateUser { get; set; }
        public EntityStateDisconnected entityStateDisconnected { get; set; }

        public string Environ { get; set; }
        public Guid ConfigID { get; set; }
        public DateTime effDT { get; set; }
        public DateTime trmDT { get; set; }
        public Guid ParamDefinitionID { get; set; }
        public bool isRefOnly { get; set; }
        public string value { get; set; }
        public string valueUseageComments { get; set; }

        }
    }
