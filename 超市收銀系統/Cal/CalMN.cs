namespace 超市收銀系統
{
    class CalMN : CalFather
    {
        //買M送N
        public double M { get; set; }
        public double N { get; set; }
        public CalMN(double m, double n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetTotalMoney(double money)
        {
            if (money >= this.M)
            {
                return money - (int)(money / this.M) * this.N;
            }
            else
            {
                return money;
            }
        }
    }



}
