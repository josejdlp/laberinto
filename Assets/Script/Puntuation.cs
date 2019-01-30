using System;

    [System.Serializable]
    public class Puntuation
    {
        public int time;
        public string date;
       

        public Puntuation(int _time, string _date)
        {
            this.time = _time;
            this.date = _date;
        }
    }

