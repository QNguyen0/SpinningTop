using System;
using Sim;
class Program 
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello MEE 484.");
        double t= 0.0;
        double tEnd = 10;
        double dt = 0.02;
        
        string s;

        SpinningTop p  = new SpinningTop();
        while(t<tEnd)
        {
            p.step(dt);
            s = $"{t.ToString("0.####")},{p.q0.ToString("0.####")},{p.q1.ToString("0.####")},{p.q2.ToString("0.####")},{p.q3.ToString("0.####")},{p.omega1.ToString("0.####")},{p.omega2.ToString("0.####")},{p.omega3.ToString("0.####")},{p.IG10.ToString("0.####")},{p.IG2.ToString("0.####")},{p.IG30.ToString("0.####")}";
            Console.WriteLine(s);
            t+=dt;
        }

    }

    
}

