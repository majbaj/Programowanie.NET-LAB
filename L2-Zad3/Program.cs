using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MonitoringTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config = LoadConfig();

            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

            // dziennik zdarzeń
            EventLog eventLog = new EventLog("Application");
            eventLog.Source = "MonitoringTool";

            while (true)
            {
                float cpuUsage = cpuCounter.NextValue();
                float availableRAM = ramCounter.NextValue();

                LogToFile(cpuUsage, availableRAM);

                // wartość progowa
                if (cpuUsage > config.CpuThreshold || availableRAM < config.RamThreshold)
                {
                    // logowanie zdarzenia
                    string message = $"Przekroczono prog wartości. Użycie CPU: {cpuUsage}%, Dostępna pamięć RAM: {availableRAM} MB";
                    LogEvent(eventLog, message, EventLogEntryType.Warning);
                }

                Thread.Sleep(config.Interval * 1000);
            }
        }

        static void LogToFile(float cpuUsage, float availableRAM)
        {
            string logMessage = $"Użycie CPU: {cpuUsage}%, Dostępna pamięć RAM: {availableRAM} MB";
            File.AppendAllText("log.txt", $"{DateTime.Now}: {logMessage}\n");
        }

        static void LogEvent(EventLog eventLog, string message, EventLogEntryType entryType)
        {
            eventLog.WriteEntry(message, entryType);
        }

        static Config LoadConfig()
        {
            if (File.Exists("config.json"))
            {
                string json = File.ReadAllText("config.json");
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(json);
            }
            else
            {
                Config defaultConfig = new Config
                {
                    CpuThreshold = 80, // Próg użycia CPU (%)
                    RamThreshold = 512, // Próg dostępnej pamięci RAM (MB)
                    Interval = 5 // Interwał czasowy (s)
                };

                string json = Newtonsoft.Json.JsonConvert.SerializeObject(defaultConfig);
                File.WriteAllText("config.json", json);

                return defaultConfig;
            }
        }
    }

    class Config
    {
        public float CpuThreshold { get; set; } // Próg użycia CPU (%)
        public float RamThreshold { get; set; } // Próg dostępnej pamięci RAM (MB)
        public int Interval { get; set; } // Interwał czasowy (s)
    }
}