using System;

namespace SOLID_Examples
{
	//A class should have only one reason to change

	//Ex: the water heater in a coffee machine should not mix sugar in it

	#region Bad Code
	class Bakery
	{
		public void RegisterOrder(Customer customer, BakeryProduct product, int quantity)
		{
			//Some logic for saving the order
			SendEmail(customer, "Your order was registered successfully");
		}

		public void Bake(Order order)
		{
			//Some baking logic
			SendEmail(order.Customer, "Your food is ready");
		}

		private void SendEmail(Customer customer, string message)
		{
			//Sending an email "Your order is ready"
		}

	}
	public class Order
	{
		public Customer Customer { get; set; }
	}
	public class Customer
	{

	}
	public enum BakeryProduct
	{
		Bread,
		Cake,
		Donut
	}
	#endregion

	#region Good Code
	//class Bakery
	//{
	//	private OrderManager _orderManager;
	//	private Oven _oven;

	//	public void RegisterOrder(Customer customer, BakeryProduct product, int quantity)
	//	{
	//		_orderManager.RegisterOrder(customer, product, quantity);
	//		MailManager.SendEmail(customer, "Your order was registered successfully");
	//	}

	//	public void Bake(Order order)
	//	{
	//		_oven.Bake(order);
	//		MailManager.SendEmail(order.Customer, "Your food is ready");
	//	}

	//}

	//public class OrderManager
	//{
	//	public void RegisterOrder(Customer customer, BakeryProduct product, int quantity)
	//	{
	//		//Some logic for registering the order
	//	}
	//}
	//public class Oven
	//{
	//	public void Bake(Order order)
	//	{
	//		//Some baking logic
	//	}

	//}
	//public class MailManager
	//{
	//	public static void SendEmail(Customer customer, string message)
	//	{
	//		//Sending an email
	//	}

	//}

	//public class Order
	//{
	//	public Customer Customer { get; set; }
	//}
	//public class Customer
	//{

	//}
	//public enum BakeryProduct
	//{
	//	Bread,
	//	Cake,
	//	Donut
	//}
	#endregion
}
