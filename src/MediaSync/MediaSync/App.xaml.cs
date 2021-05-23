using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace MediaSync {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private readonly IHost host;

        public App() {
            host = new HostBuilder().ConfigureServices((context, services) => {
                services.AddSingleton<TryIcon>();
            }).ConfigureLogging(logs => {
                logs.SetMinimumLevel(LogLevel.Information)
                    .AddLog4Net("log4net.config");
            }).Build();
        }

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            var logs = host.Services.GetService<ILogger<App>>();
            logs.LogInformation("Testing!");
            var tray = host.Services.GetService<TryIcon>();
            tray.Show();
        }

        protected override async void OnExit(ExitEventArgs e) {
            using (host) {
                await host.StopAsync();
            }

            base.OnExit(e);
        }
    }
}
