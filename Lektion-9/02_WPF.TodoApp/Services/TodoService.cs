using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace _02_WPF.TodoApp.Services
{
    internal static class TodoService
    {
        public static string StateMessage(State state)
        {
            switch (state)
            {
                case State.Saving:
                    return "Sparar...";

                case State.Saved:
                    return "Sparad";

                case State.SavedFailed:
                    return "Något gick fel vid sparningen";

                case State.Removing:
                    return "Tar bort...";

                case State.Removed:
                    return "Borttaget";

                case State.RemovedFailed:
                    return "Borttaget misslyckades";

                default:
                    return "";
            }

        }


    }
}
