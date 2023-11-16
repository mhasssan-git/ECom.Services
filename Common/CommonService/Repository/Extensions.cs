using CommonService.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
namespace CommonService.Repository
{
    public static class Extensions
    {
        public static IServiceCollection AddMongoDb(this IServiceCollection services)
        {
            BsonSerializer.RegisterSerializer(new GuidSerializer(MongoDB.Bson.BsonType.String));
            BsonSerializer.RegisterSerializer(new DateTimeOffsetSerializer(MongoDB.Bson.BsonType.String));
            _ = services.AddSingleton(provider =>
            {
                var configuration = provider.GetService<IConfiguration>();
                ServiceSettings serviceSettings=configuration.GetSection(nameof(ServiceSettings)).Get<ServiceSettings>();
                var mongoDbSettings = configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();
                var mongoClient = new MongoClient(mongoDbSettings.ConnectionString);
                return mongoClient.GetDatabase(serviceSettings.ServiceName);
            });
            return services;
        }

        public static IServiceCollection AddMySqlDb<TDbContext>(this IServiceCollection services,IConfiguration configuration) where TDbContext : DbContext
        {
            var mySqlDbSettings = configuration.GetSection(nameof(MySqlSettings)).Get<MySqlSettings>();
            _ =services.AddDbContextPool <TDbContext> (options =>
            {
                options.EnableSensitiveDataLogging(true);
                options.UseMySql(mySqlDbSettings.ConnectionString,
                    ServerVersion.AutoDetect(mySqlDbSettings.ConnectionString),
                    builder => { builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null); });
            });
            return services;
        }

    }
}
