namespace 超市收銀系統
{
    class CalRate : CalFather
    {
        //打折
        public double Rate { get; set; }
        public CalRate(double rate)
        {
            this.Rate = rate;
        }

        public override double GetTotalMoney(double money)
        {
            return money * this.Rate;
        }
    }



}
