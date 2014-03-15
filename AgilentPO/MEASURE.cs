using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilentPO
{
    public class MEASURE
    {
        MEASPOINT[] measdata;
        int pointnum;
        public MEASURE(int pntnum)//Number of points
        {
            pointnum = pntnum;
        }

        public int Points(){
            return pointnum;
        }

        public MEASPOINT[] GetMeasureData(){
            return measdata;
        }

        public Boolean Connect(string host)
        {

            return true;
        }

        void MeasureDone()
        {
            measdata = new MEASPOINT[pointnum];
            Random rnd = new Random();
            for (int i = 0; i < pointnum; i++)
            {
                measdata[i] = new MEASPOINT(28.000 + rnd.Next(4000)/1000,8.000 + rnd.Next(3000)/1000);
            }
        }

        public void Start()
        {
            MeasureDone();
        }

        public void AddPoint(MEASPOINT pnt)
        {
            //measdata = measdata + pnt;
        }

        bool FreqSelector()
        {

            return true;
        }

        public MEASPOINT MinFreq(){
            return measdata.Min();
        }

        public MEASPOINT MinRefl()
        {
            return measdata.Min();
        }

        public MEASPOINT MaxFreq()
        {
            return measdata.Max();
        }

        public MEASPOINT MaxRefl()
        {
            return measdata.Max();
        }
    }
}
