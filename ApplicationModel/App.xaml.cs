#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Application = System.Windows.Application;

namespace ApplicationModel {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        protected override void OnStartup(StartupEventArgs e) {            
            DispatcherUnhandledException += MainUIThreadUnhandledException;
            Current.Dispatcher.UnhandledException += DispatcherOnUnhandledException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            TaskScheduler.UnobservedTaskException += TaskSchedulerOnUnobservedTaskException;
        }

        private void MainUIThreadUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
            Debug.WriteLine("MainUIThreadUnhandledException");
            e.Handled = true;
        }

        private void DispatcherOnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) {
            Debug.WriteLine("DispatcherOnUnhandledException");
            e.Handled = true;
        }

        private void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e) {
            Debug.WriteLine("CurrentDomainOnUnhandledException");            
        }

        private void TaskSchedulerOnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e) {
            Debug.WriteLine("TaskSchedulerOnUnobservedTaskException");            
            e.SetObserved();
        }
    }
}