

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <DevNotes>
    /// Couldn't figure out modelbuilder syntax for ingnoring the enum version of this
    /// Easier with class: modelBuilder.Ignore<EntityStateDisconnected>();
    /// Harder with enum: compose for for each Table (modelBuilder.Table.column.Ignore();)
    /// </DevNotes>
    /// <summary>
    /// class that works as an enum and weak event store
    /// </summary>
    public class EntityStateDisconnected
        {
        /// <summary>
        /// Mutable value
        /// </summary>
        public int value { get; private set; }
        public bool wasAdded { get; private set; }
        public bool wasChanged { get; private set; }
        public bool wasDeleted { get; private set; }

        public EntityStateDisconnected()
            {
            value = 0;
            wasAdded = false;
            wasChanged = false;
            wasDeleted = false;
            }

        public void unchanged() { value = 0; }
        public void added()
            { value = 1;
            if(!wasAdded)
                { wasAdded = true; }
            }
        public void changed()
            { value = 2;
            if ( !wasChanged)
                { wasChanged = true; }
            }
        public void deleted()
            { value = 3;
            if ( !wasDeleted)
                { wasDeleted = true; }
            }
        }

    //public enum EntityStateDisconnected
    //    {
    //    unchanged 
    //    , added 
    //    ,changed 
    //    ,deleted 
    //    }

    }
