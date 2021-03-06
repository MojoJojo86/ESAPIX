﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ESAPIX.AppKit.Data
{
    public class StorageHelper
    {
        private static string defaultStoragePath = @"ESAPI_Storage\";
        private static string defaultSettingsFileName = "settings.json";
        private static string tempStorage = @"Temp";


        public static string GetBasePath(string storagePath = "")
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path = Path.Combine(path, string.IsNullOrEmpty(storagePath)?defaultStoragePath:storagePath);
            return path;
        }

        public static void CreateBasePathIfNotExists(string path)
        {
            path = string.IsNullOrEmpty(path)?GetBasePath(): Path.GetDirectoryName(path);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static string GetSettingsPath(string settingsFileName = "")
        {
            var filePath = Path.Combine(GetBasePath(), string.IsNullOrEmpty(settingsFileName) ? defaultSettingsFileName : settingsFileName);
            return filePath;
        }


        public static void CreateTempPathIfNotExists()
        {
            var tempPath = GetTempStoragePath();
            if (!Directory.Exists(tempPath))
            {
                Directory.CreateDirectory(tempPath);
            }
        }

        public static string GetTempStoragePath()
        {
            var tempPath = Path.Combine(GetBasePath(), tempStorage);
            return tempPath;
        }

    }
}
