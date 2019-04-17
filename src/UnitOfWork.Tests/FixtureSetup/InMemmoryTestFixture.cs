using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWork.Implementations.Infraestructure.Context;

namespace UnitOfWork.Tests.FixtureSetup
{
    public class InMemmoryTestFixture : IDisposable
    {
        public ApplicationDatabaseContext Context => InMemoryContext();

        public void Dispose()
        {
            Context?.Dispose();
        }

        private static ApplicationDatabaseContext InMemoryContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDatabaseContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .EnableSensitiveDataLogging()
                .Options;
            var context = new ApplicationDatabaseContext(options);

            return context;
        }
    }
}
