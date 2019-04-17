using System;

namespace UnitOfWork.Tests.FixtureSetup
{
    public class DatabaseFixture : IDisposable
    {
        public DatabaseFixture()
        {
            
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
        }

    }
}
