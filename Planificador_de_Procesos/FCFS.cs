using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planificador_de_Procesos
{
    class FCFS
    {
        private int[] _process;
        int[] _waitingtime;
        int[] _responsetime;
        int[] _rembt;
        int[] _tat;
        int[] _copy;
        string _p;
        string _waittingTimes;
        Random rt = new Random();

        public string P
        {
            get { return _p; }
        }
        public string WaitingTime
        {
            get { return _waittingTimes; }
        }
        public FCFS(int size)
        {
            _process = new int[size];
            _waitingtime = new int[size];
            _responsetime = new int[size];
            _rembt = new int[size];
            _tat = new int[size];
            _copy = new int[size];
        }

        int tat = 0;
        int ret = 0;
        int temp = 0;

        public void fill(int max)
        {
            for (int i = 0; i < _process.Length; i++)
            {
                _process[i] = rt.Next(1, max + 1);
                _copy[i] = _process[i];
            }
            
        }

        public int Cmax()
        {
            int cmax = 0;
            for (int i = 0; i < _process.Length; i++)
            {
                cmax += _process[i];
            }
            return cmax;
        }

        public float Waitedtime()
        {
            
            int tat = 0;
            int temp = 0;
            cleanVector();
           for(int i = 0; i < _process.Length-1; i++)
            {
                _waitingtime[i] = temp + _process[i];
                temp += _process[i];
                tat += _waitingtime[i];
            }
            return (float)tat / _process.Length;
        }

        public float Responetime()
        {
            _waittingTimes = "0 ";
            _p = " ";
            int ret = 0;
            temp = 0;
            cleanVector();
            for (int i = 0; i < _process.Length; i++)
            {
                _responsetime[i] = temp + _process[i];
                temp += _process[i];
                _waittingTimes += "----" + temp;
                ret += _responsetime[i];
                _p += "| P" + i + " | ";
            }
            return (float)ret / _process.Length;
        }
        public string show()
        {
            string processes = "";
            for (int i = 0; i < _process.Length; i++)
            {
                processes += "Proceso " + (i + 1) + " es: " + _process[i] + "\r\n";
            }
            return processes;
        }

        public void Normal()
        {
            for (int i = 0; i < _process.Length; i++)
            {
                _process[i] = _copy[i];
            }
        }

        public void PosicionSJF()
        {
            for (int j = 0; j < _process.Length-1; j++)
            {
                for (int i = 0; i < _process.Length-1; i++)
                {
                    if (_process[i] > _process[i + 1])
                    {
                        int shortest = _process[i];
                        _process[i] = _process[i + 1];
                        _process[i + 1] = shortest;
                    }
                }
            }
        }
        public void PosicionLJF()
        {
            for(int j = 0; j < _process.Length - 1; j++)
            {
                for (int i = 0; i < _process.Length - 1; i++)
                {
                    if (_process[i] < _process[i + 1])
                    {
                        int shortest = _process[i];
                        _process[i] = _process[i + 1];
                        _process[i + 1] = shortest;
                    }
                }
            }
        }

        int totalwt = 0;
        int totalrt = 0;
        public void roundrobin(int quantum)
        {
            for (int i = 0; i < _process.Length; i++)
            {
                _waitingtime[i] = 0;
            }
            for (int i = 0; i < _process.Length; i++)
            {
                _rembt[i] = _process[i];
            }
            int time = 0;
            bool done = false;
            while (done != true)
            {
                done = true;
                for (int i = 0; i < _process.Length; i++)
                {
                    if (_rembt[i] > 0)
                    {
                        done = false;
                        if (_rembt[i] > quantum)
                        {
                            time += quantum;
                            _rembt[i] -= quantum;
                        }
                        else
                        {
                            time += _rembt[i];
                            _waitingtime[i] = time - _rembt[i];
                            if(_rembt[i] == 0)
                            {
                                _waitingtime[i] = time - quantum;
                            }

                            _rembt[i] = 0;
                        }
                    }
                }
                time = time - quantum;
            }
        }

        public float rrWT(int quantum)
        {
            totalwt = 0;
            roundrobin(quantum);
            for (int i = 0; i < _process.Length; i++)
            {
                totalwt += _waitingtime[i];
            }
            return (float)totalwt / _process.Length;
        }

        public float rrRt(int quantum)
        {
            totalrt = 0;
            roundrobin(quantum);
            for (int i = 0; i < _process.Length; i++)
            {
                _tat[i] = _process[i] + _waitingtime[i];
            }
            for (int i = 0; i < _process.Length; i++)
            {
                totalrt += _tat[i];
            }
                return (float)totalrt / _process.Length;
        }

        public void cleanVector()
        {
            for (int i = 0; i < _process.Length; i++)
            {
                _waitingtime[i] = 0;
            }
        }
    }
}

