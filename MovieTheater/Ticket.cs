namespace MovieTheater
{
    public class Ticket
    {

        public int basePriceSmall { get; set; }
        public int basePriceBig { get; set; }
        public int basePriceVIP { get; set; }
        public Theater theater { get; set; }
        public string customer { get; set; }
        
        public int CalculatedPrice { get; set; }
        public Ticket(Theater theater, string customer)
        {
            basePriceSmall = 1000;
            basePriceBig = 2000;
            basePriceVIP = 5000;
            this.theater = theater;
            this.customer = customer;
        }

       

        public void calculateDiscountPrice()
        {
            switch (customer)
            {
                case "gyerek":
                    if(theater is SmallTheater)
                    {
                        CalculatedPrice = (int)(basePriceSmall * ((100 - 40) / 100.0));
                    }else if(theater is BigTheater)
                    {
                        CalculatedPrice = (int)(basePriceBig * ((100 - 40) / 100.0));
                    }else
                    {
                        CalculatedPrice = basePriceVIP;
                    }
                    break;
                case "diak":
                    if(theater is SmallTheater)
                    {
                        CalculatedPrice = (int)(basePriceSmall * ((100 - 30) / 100.0));
                    }else if(theater is BigTheater)
                    {
                        CalculatedPrice = (int)(basePriceBig * ((100 - 20) / 100.0));
                    }
                    else
                    {
                        CalculatedPrice = basePriceVIP;
                    }
                    break;

                case "felnott":
                    if(theater is SmallTheater)
                    {
                        CalculatedPrice = (int)(basePriceSmall * ((100 - 10) / 100.0));
                    }else if(theater is BigTheater)
                    {
                        CalculatedPrice = basePriceBig;
                    }
                    else
                    {
                        CalculatedPrice = basePriceVIP;
                    }
                    break;

                case "nyugdijas":
                    if(theater is SmallTheater)
                    {
                        CalculatedPrice = (int)(basePriceSmall * ((100 - 30) / 100.0));
                    }else if(theater is BigTheater)
                    {
                        CalculatedPrice = (int)(basePriceBig * ((100 - 20) / 100.0));
                    }
                    else
                    {
                        CalculatedPrice = basePriceVIP;
                    }
                    break;

                case "torzstag":
                    if(theater is SmallTheater)
                    {
                        CalculatedPrice = (int)(basePriceSmall * ((100 - 30) / 100.0));
                    }else if(theater is BigTheater)
                    {
                        CalculatedPrice = (int)(basePriceBig * ((100 - 30) / 100.0));
                    }
                    else
                    {
                        CalculatedPrice = basePriceVIP;
                    }
                    break;
                default:
                    CalculatedPrice = basePriceVIP;
                    break;
            }
        }

       
    }
}
