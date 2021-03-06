﻿namespace Azi.Cloud.Common
{
    using System.ComponentModel;
    using System.Configuration;

    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class CloudInfo : INotifyPropertyChanged
    {
        private string assemblyFileName;

        private bool autoMount;

        private string className;

        private char driveLetter;

        private string name;

        private bool readOnly;

        public event PropertyChangedEventHandler PropertyChanged;

        public string AssemblyFileName
        {
            get
            {
                return assemblyFileName;
            }

            set
            {
                assemblyFileName = value;
                OnPropertyChanged(nameof(AssemblyFileName));
            }
        }

        public string AuthSave { get; set; }

        public bool AutoMount
        {
            get
            {
                return autoMount;
            }

            set
            {
                autoMount = value;
                OnPropertyChanged(nameof(AutoMount));
            }
        }

        public string ClassName
        {
            get
            {
                return className;
            }

            set
            {
                className = value;
                OnPropertyChanged(nameof(ClassName));
            }
        }

        public char DriveLetter
        {
            get
            {
                return driveLetter;
            }

            set
            {
                driveLetter = value;
                OnPropertyChanged(nameof(DriveLetter));
            }
        }

        public string Id { get; set; }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public bool ReadOnly
        {
            get
            {
                return readOnly;
            }

            set
            {
                readOnly = value;
                OnPropertyChanged(nameof(ReadOnly));
            }
        }

        internal void OnPropertyChanged(string propname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
        }
    }
}