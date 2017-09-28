using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;

using dfbModels;

namespace dfbStartup
{
  static public class JsonConfiguration
  {
      public static IConfigurationRoot Config{ get; set; }

      public static void Init(string fileName)
      {
          var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile(fileName);

          Config = builder.Build();
      }
  }
}