using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal interface IState { }

    public class StopState : IState
    {
        public override string ToString()
        {
            return "Приостановлена";
        }
    }

    public class StopingState : IState
    {
        public override string ToString()
        {
            return "Останавливается";
        }
    }

    public class PlayState : IState
    {
        public override string ToString()
        {
            return "Воспроизводится";
        }
    }

    public class RewindState() : IState
    {
        public override string ToString()
        {
            return "Перематывается";
        }
    }
}
