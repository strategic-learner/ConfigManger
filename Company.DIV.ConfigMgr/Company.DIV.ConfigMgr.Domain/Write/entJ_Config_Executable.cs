using System;

namespace Company.DIV.ConfigMgr.Domain.Write
    {

    public class JConfigExecutable : EntityWrite, IJConfigExecutableWrite
        {
        private JConfigExecutable() { }

        
        public Guid ConfigID { get; private set; }
        public Guid ExecutableID { get; private set; }


        
        
        }
    }