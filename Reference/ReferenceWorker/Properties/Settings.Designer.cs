﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReferenceWorker.Properties {
    
    
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [System.Configuration.ApplicationScopedSettingAttribute()]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.Configuration.SpecialSettingAttribute(System.Configuration.SpecialSetting.ConnectionString)]
        [System.Configuration.DefaultSettingValueAttribute("Data Source=ULGES-SQL2;Initial Catalog=GES;Integrated Security=True")]
        public string GESConnectionString {
            get {
                return ((string)(this["GESConnectionString"]));
            }
        }
    }
}