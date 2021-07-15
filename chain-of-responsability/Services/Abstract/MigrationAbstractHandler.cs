namespace chain_of_responsability.Services.Abstract
{
    public abstract class MigrationAbstractHandler : IMigrateHandler
    {
        protected IMigrateHandler Next { get; set; }

        public abstract void Migrate();

        public IMigrateHandler SetHandler(IMigrateHandler handler)
        {
            this.Next = handler;
            return handler;
        }
    }
}
