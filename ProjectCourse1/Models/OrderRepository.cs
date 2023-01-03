namespace ProjectCourse1.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PieShopDbContext _PieShopDbContext;
        private readonly IShoppingCart _shoppingCart;

        public OrderRepository(PieShopDbContext PieShopDbContext, IShoppingCart shoppingCart)
        {
            _PieShopDbContext = PieShopDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            List<ShoppingCartItem>? shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetails>();

            foreach (ShoppingCartItem? shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetails
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Pie.PieId,
                    Price = shoppingCartItem.Pie.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _PieShopDbContext.Orders.Add(order);

            _PieShopDbContext.SaveChanges();
        }
    }
}
