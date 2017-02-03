using System;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <summary>
    /// this object is the base JPlanLOB entity plus PlanAbbr & LOBAbbr
    /// </summary>
    public class DTOConfigParam : IDTOConfigParam
        {
        private DTOConfigParam() { }
        public DTOConfigParam( 
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


        public string Environ { get; private set; }
        public Guid ID { get; private set; }
        public Guid ConfigID { get; private set; }

        public DateTime effDT { get; private set; }

        public DateTime trmDT { get; private set; }

        public Guid ParamDefinitionID { get; private set; }

        public bool isRefOnly { get; private set; }

        public string value { get; private set; }

        public string valueUseageComments { get; private set; }

        }
    }
