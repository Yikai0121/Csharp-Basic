namespace 超市收銀系統
{
    public class ProductFather
    {
        public double Price { get; set; }

        public string Name { get; set; }

        //使用string->運用Guid方法
        public string ID { get; set; }

        public ProductFather(string id, double price, string name)
        {
            this.Price = price;
            this.Name = name;
            this.ID = id;
        }
    }

}
