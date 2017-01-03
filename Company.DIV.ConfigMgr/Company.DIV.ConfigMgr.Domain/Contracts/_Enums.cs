using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DIV.ConfigMgr.Domain
    {
    /// <DevNotes>
    /// Couldn't figure out modelbuilder syntax for ingnoring the enum version of this
    /// Easier with class: modelBuilder.Ignore<EntityStateDisconnected>();
    /// Harder with enum: modelBuilder.TableByTable.column.Ignore();
    /// </DevNotes>
    /// <summary>
    /// class that works as an enum
    /// </summary>
    public class EntityStateDisconnected
        {
        public int value { get; private set; }
        public EntityStateDisconnected()
            {
            value = 0;
            }

        public void unchanged() { value = 0; }
        public void added() { value = 1; }
        public void changed() { value = 2; }
        public void deleted() { value = 3; }
        }

    public enum EntityStateDisconnectedEnum
        {
        unchanged 
        , added 
        ,changed 
        ,deleted 
            
        }
    }
