namespace chain_of_responsability.Services.Abstract
{
    public interface IMigrateHandler
    {
        public IMigrateHandler SetHandler(IMigrateHandler handler);

        public void Migrate();
    }
}
