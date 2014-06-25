using System.ComponentModel.DataAnnotations;
using NakedObjects;

namespace Domain {

    [IconName("SimpleObject.png")]
    public class SimpleObject {

        #region Injected Services
        // This region should contain properties to hold references to any services required by the
        // object.  Use the 'injs' shortcut to add a new service; 'injc' to add an injected Container

        #endregion
        #region Life Cycle Methods
        // This region should contain any of the 'life cycle' convention methods (such as
        // Created(), Persisted() etc) called by the framework at specified stages in the lifecycle.


        #endregion

        [Key, Hidden]
        public virtual int SimpleObjectId { get; set; }

        //Add properties with 'propv', collections with 'coll', actions with 'act' shortcuts
        [Title]
        public virtual string Name { get; set; }

    }
}

