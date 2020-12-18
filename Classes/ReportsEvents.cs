using System;
using System.Threading;

namespace EIS.Classes
{
  public static class ReportsEvents
  {

        private static MainEventHandler fEvents;
        public static event MainEventHandler ReportEvent
        {
            [System.Runtime.CompilerServices.CompilerGenerated]
            add
            {
                MainEventHandler mainEventHandler = ReportsEvents.fEvents;
                MainEventHandler mainEventHandler2;
                do
                {
                    mainEventHandler2 = mainEventHandler;
                    MainEventHandler value2 = (MainEventHandler)Delegate.Combine(mainEventHandler2, value);
                    mainEventHandler = Interlocked.CompareExchange<MainEventHandler>(ref ReportsEvents.fEvents, value2, mainEventHandler2);
                }
                while (mainEventHandler != mainEventHandler2);
            }
            [System.Runtime.CompilerServices.CompilerGenerated]
            remove
            {
                MainEventHandler mainEventHandler = ReportsEvents.fEvents;
                MainEventHandler mainEventHandler2;
                do
                {
                    mainEventHandler2 = mainEventHandler;
                    MainEventHandler value2 = (MainEventHandler)Delegate.Remove(mainEventHandler2, value);
                    mainEventHandler = Interlocked.CompareExchange<MainEventHandler>(ref ReportsEvents.fEvents, value2, mainEventHandler2);
                }
                while (mainEventHandler != mainEventHandler2);
            }
        }
        public static void Report1()
        {
            if (fEvents != null)
                fEvents(null, new MainEventsArgs("first report\r\n"));
        }
    }
}
