﻿using Newtonsoft.Json;
using OTSC_ui.AppSettingJsonPhars.Temaplates;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.AppSettingJsonPhars.Reader
{
    internal class JsonReader : IJsonReader
    {
        public T Read<T>(string filePath) where T : Itemplates
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException($"File not found: {filePath}");

                string jsonContent = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(jsonContent)??throw new JsonException("empty or bad file");
            }
            catch (Exception ex)
            {
                Log.Error($"Error reading JSON file: {ex.Message}");
                throw;
            }
        }
    }
}