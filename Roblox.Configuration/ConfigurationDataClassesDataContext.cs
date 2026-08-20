using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Roblox.Configuration
{
    [Database(Name = "ConfigurationDatabase")]
    public class ConfigurationDataClassesDataContext : DataContext
    {
        private static MappingSource mappingSource = new AttributeMappingSource();

        public ConfigurationDataClassesDataContext() 
            : base(global::Roblox.Configuration.Properties.Settings.Default.ConfigurationDatabaseConnectionString, mappingSource)
        {}
        public ConfigurationDataClassesDataContext(string connection)
            : base(connection, mappingSource)
        {}
        public ConfigurationDataClassesDataContext(IDbConnection connection)
            : base(connection, mappingSource)
        {}
        public ConfigurationDataClassesDataContext(string connection, MappingSource mappingSource)
            : base(connection, mappingSource)
        {}
        public ConfigurationDataClassesDataContext(IDbConnection connection, MappingSource mappingSource)
            : base(connection, mappingSource)
        {}

        public Table<PopulatedGroup> PopulatedGroups { get { return GetTable<PopulatedGroup>(); } }
        public Table<Setting> Settings { get { return GetTable<Setting>(); } }
        public Table<ConnectionString> ConnectionStrings { get { return GetTable<ConnectionString>(); } }
        public Table<EndpointAddress> EndpointAddresses { get { return GetTable<EndpointAddress>(); } }
    }
}
