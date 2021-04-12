using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SchemeService
{
    public static class SchemeEventLog
    {
        public static void WriteEntry(string sEvent, EventLogEntryType entryType)
        {
            try
            {
                if (!EventLog.SourceExists(SchemeEventLog.sSource))
                {
                    EventLog.CreateEventSource(SchemeEventLog.sSource, SchemeEventLog.sLog);
                }
                EventLog.WriteEntry(SchemeEventLog.sSource, sEvent, entryType);
            }
            catch
            {
            }
        }

        private static string sSource = "SchemeService";

        private static string sLog = "Service";
    }
}
