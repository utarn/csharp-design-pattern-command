namespace pattern_command
{
    public class AddOrderCommand : Command
    {
        private readonly OrderService _orderService;
        public AddOrderCommand(OrderService orderService)
        {
            _orderService = orderService;
        }
        public void Execute()
        {
            _orderService.AddOrder();
        }
    }
}