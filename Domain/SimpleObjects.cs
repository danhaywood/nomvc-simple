using System.Linq;
using NakedObjects;


namespace Domain
{
    //[DisplayName("")]
    public class SimpleObjects
    {
        #region Injected Services
        // This region should contain properties to hold references to any services required by the
        // object.  Use the 'injs' shortcut to add a new service.
        public IDomainObjectContainer Container { set; protected get; }
        #endregion

        // 'fact' shortcut to add a factory method, 
        // 'alli' for an all-instances method
        // 'find' for a method to find a single object by query
        // 'list' for a method to return a list of objects matching a query


        public SimpleObject CreateNewSimpleObject(string name)
        {
            var obj = Container.NewTransientInstance<SimpleObject>();
            obj.Name = name;
            Container.Persist(ref obj);
            return obj;
        }

        [QueryOnly]
        public IQueryable<SimpleObject> AllSimpleObjects()
        {
            return Container.Instances<SimpleObject>();
        }


        #region Find
        [QueryOnly]
        public SimpleObject Find(string name)
        {
            var query = from obj in Container.Instances<SimpleObject>()
                        where obj.Name == name
                        select obj;

            return query.FirstOrDefault();
        }
        #endregion



    }
}
