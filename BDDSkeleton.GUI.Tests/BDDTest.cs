namespace BDDSkeleton.GUI.Tests
{
    public abstract class BDDTest<T> where T : BDDTest<T>
    {
        protected T Given { get { return (T)this; } }
        protected T When { get { return (T)this; } }
        protected T Then { get { return (T)this; } }
        protected T Shall { get { return (T)this; } }
        protected T And { get { return (T)this; } }
    }
}
