using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Music
    {
        private string _name;
        private IState _state;

        public string Name { get => _name; }

        public Music(string name, IState state)
        {
            _name = name;
            _state = state;
        }

        public override string ToString()
        {
            return $"\"{_name}\": {_state}";
        }
        public void Stop()
        {
            System.Threading.Thread.Sleep(5000);
            _state = new StopingState();
            Console.WriteLine(this);
            System.Threading.Thread.Sleep(5000);
            _state = new StopState();
            Console.WriteLine(this);
        }
        public void Play()
        {
            System.Threading.Thread.Sleep(5000);
            _state = new PlayState();
            Console.WriteLine(this);
        }
        public void PlayNext(Music nextMusic)
        {
            System.Threading.Thread.Sleep(5000);
            _state = new RewindState();
            Console.WriteLine(this);
            System.Threading.Thread.Sleep(5000);
            nextMusic._state = new PlayState();
            Console.WriteLine(nextMusic);
        }
    }
}
