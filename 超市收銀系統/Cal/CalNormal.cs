namespace 超市收銀系統
{
    class CalNormal : CalFather
    {
        //沒打折
        public override double GetTotalMoney(double money)
        {
            return money;
        }
    }



}
