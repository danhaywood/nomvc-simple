using System.Data.Entity;

namespace Domain
{
    public class SimpleDbInitialiser : DropCreateDatabaseIfModelChanges<SimpleDbContext>
    {

        protected override void Seed(SimpleDbContext simpleDbContext)
        {
            //var f1 = NewFoo("Foo 1", context);
        }

        //private Foo NewFoo(string name, MyDbContext context)
        //{
        //    Foo foo = new Foo() {Name = name};
        //    context.Foos.Add(foo);
        //    return foo;
        //}
    }
}