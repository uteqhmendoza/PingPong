using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PingPong.Consola
{
    public class Command 
    {
        Func<ConsoleKeyInfo, bool> canExecute;
        Action<Jugador> execute;

        public Command(Func<ConsoleKeyInfo, bool> funcionCanExecute, Action<Jugador> actionExecute)
        {
            canExecute = funcionCanExecute;
            execute = actionExecute;
        }

        public bool CanExecute(ConsoleKeyInfo parameter)
        {
            return canExecute(parameter);
        }

        public void Execute(Jugador parameter)
        {
            execute(parameter);
        }
    }
}
