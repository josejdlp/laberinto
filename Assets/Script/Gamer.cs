using System;
using System.Collections.Generic;

[System.Serializable]
public class Gamer
{
    public string name;
    public int age;
    public List<Puntuation> l1=new List<Puntuation>();
    public List<Puntuation> l2 = new List<Puntuation>();
    public List<Puntuation> l3 = new List<Puntuation>();

    public Gamer(string _name, int _age,List<Puntuation> _l1, List<Puntuation> _l2, List<Puntuation> _l3)
    {
        this.name = _name;
        this.age = _age;
        this.l1 = _l1;
        this.l2 = _l2;
        this.l3 = _l3;

    }
    public Gamer() { }
    public void setName(string name) {
        this.name = name;
    }
    public void setAge(int age) {
        this.age = age;
    }
    public void addL1(int time,string date) {
        this.l1.Add(new Puntuation(time, date));
    }
    public void addL2(int time, string date)
    {
        this.l2.Add(new Puntuation(time, date));
    }
    public void addL3(int time, string date)
    {
        this.l3.Add(new Puntuation(time, date));
    }
}