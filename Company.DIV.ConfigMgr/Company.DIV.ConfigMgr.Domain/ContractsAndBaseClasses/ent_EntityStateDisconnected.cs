

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
        public int value { get; private set; } = 0;
        public bool wasAdded { get; private set; } = false;
        public bool wasChanged { get; private set; } = false;
        public bool wasDeleted { get; private set; } = false;
        public bool cancelChanges { get; private set; } = false;

        public EntityStateDisconnected()
            {
            }

        public void cancel()
            {value = 0;
            cancelChanges = true; }
        public void added()
            { value = 1;
            wasAdded = true; }
        public void changed()
            { value = 2;
            wasChanged = true; }
        public void deleted()
            { value = 3;
            wasDeleted = true; }
        }
    
    }
