﻿namespace Ana.Source.Scanners
{
    using System;
    using System.ComponentModel;
    using UserSettings;
    using Utils;

    /// <summary>
    /// The base of all scanner classes
    /// </summary>
    internal abstract class ScannerBase : RepeatedTask, INotifyPropertyChanged
    {
        /// <summary>
        /// The number of scans completed
        /// </summary>
        private Int32 scanCount;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScannerBase" /> class
        /// </summary>
        /// <param name="scannerName">The name of this scanner</param>
        public ScannerBase(String scannerName)
        {
            this.ScannerName = scannerName;
        }

        /// <summary>
        /// Occurs after a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the number of scans that have been executed
        /// </summary>
        public Int32 ScanCount
        {
            get
            {
                return this.scanCount;
            }

            private set
            {
                this.scanCount = value;
                this.NotifyPropertyChanged(nameof(this.ScanCount));
            }
        }

        /// <summary>
        /// Gets the name of this scanner
        /// </summary>
        protected String ScannerName { get; private set; }

        /// <summary>
        /// Begins the scan
        /// </summary>
        public override void Begin()
        {
            this.ScanCount = 0;
            this.UpdateInterval = SettingsViewModel.GetInstance().RescanInterval;
            base.Begin();
        }

        /// <summary>
        /// Notifies view model of a property change
        /// </summary>
        /// <param name="propertyName">The name of the changing property</param>
        protected void NotifyPropertyChanged(String propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Updates the scan
        /// </summary>
        protected override void OnUpdate()
        {
            this.ScanCount++;
            this.UpdateInterval = SettingsViewModel.GetInstance().RescanInterval;
        }
    }
    //// End class
}
//// End namespace