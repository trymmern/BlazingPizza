namespace BlazingPizza.Client
{
    public class OrderState
    {
        public bool ShowConfiguringDialog { get; private set; }
        public Pizza ConfiguringPizza { get; private set; }
        public Order Order { get; private set; } = new();
        
        public void ShowConfiguringPizzaDialog(PizzaSpecial special)
        {
            ConfiguringPizza = new Pizza
            {
                Special = special,
                SpecialId = special.Id,
                Size = Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>()
            };

            ShowConfiguringDialog = true;
        }
        
        public void CancelConfigurePizzaDialog()
        {
            ResetConfiguringPizza();
        }

        public void ConfirmConfigurePizzaDialog()
        {
            Order.Pizzas.Add(ConfiguringPizza);
            ResetConfiguringPizza();
        }

        public void RemoveConfiguredPizza(Pizza pizza)
        {
            Order.Pizzas.Remove(pizza);
        }

        public void ResetOrder()
        {
            Order = new Order();
        }

        public void ReplaceOrder(Order order)
        {
            Order = order;
        }
        
        private void ResetConfiguringPizza()
        {
            ConfiguringPizza = null;
            ShowConfiguringDialog = false;
        }
    }
}