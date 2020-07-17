using System;

namespace Classbasic
{
    //票價系統計算
    //距離和價錢只可唯獨
    //並依距離打折
    public class Ticket
    {
        double _distance;
        public double Distance
        {
            get { return _distance; }
        }
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }

            this._distance = distance;
        }

        double _price;
        public double Price
        {
            get
            {
                if (_distance > 0 && Distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if (_distance > 100 && _distance <= 200)
                {
                    return _distance * 0.95;
                }
                else
                {
                    return _distance * 0.9;
                }

            }
        }

        public void ShowPrice()
        {
            Console.WriteLine("{0}公里總共{1}元", Distance, Price);
        }










    }
}
