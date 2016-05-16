﻿using System.IO;

using Newtonsoft.Json;

using Norma.Models.Config;

namespace Norma.Models
{
    internal class Configuration
    {
        public ConfigRoot Root { get; private set; }

        public Configuration()
        {
            Load();
            Save();
        }

        private void Load()
        {
            if (!File.Exists(NormaConstants.ConfigurationFile))
            {
                Root = new ConfigRoot();
                Migrate();
                return;
            }
            using (var sr = File.OpenText(NormaConstants.ConfigurationFile))
            {
                var serializer = new JsonSerializer();
                Root = (ConfigRoot) serializer.Deserialize(sr, typeof(ConfigRoot));
            }
            Migrate();
        }

        public void Save()
        {
            using (var sw = File.CreateText(NormaConstants.ConfigurationFile))
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(sw, Root);
            }
        }

        private void Migrate()
        {

        }
    }
}