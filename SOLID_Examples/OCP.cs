using System;

namespace SOLID_Examples
{
	//Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification	

	//Ex: A pianist must be able any music which has notes

	#region Bad code
	public class PaymentManager
	{
		public void Pay(decimal amount, PaymentMode paymentMode)
		{
			switch (paymentMode)
			{
				case PaymentMode.Cash:
					//logic to pay with cash
					break;
				case PaymentMode.CreditCard:
					//logic to pay with credit card
					break;
				case PaymentMode.QIWI:
					//logic to pay with qiwi wallet
					break;
				default:
					break;
			}
		}
	}
	public enum PaymentMode
	{
		Cash,
		CreditCard,
		QIWI
	}
	#endregion

	#region Good code

	//public interface IPaymentMethod
	//{
	//	void Pay(decimal amount);
	//}
	//public class PaymentManager
	//{
	//	public void Pay(decimal amount, IPaymentMethod paymentMethod)
	//	{
	//		paymentMethod.Pay(amount);
	//	}
	//}
	//public class QiwiPay : IPaymentMethod
	//{
	//	public void Pay(decimal amount)
	//	{
	//		//Logic to pay with QIWI wallet
	//	}
	//}
	//public class GooglePay : IPaymentMethod
	//{
	//	public void Pay(decimal amount)
	//	{
	//		//Logic to pay with Google pay
	//	}
	//}
	//public class CashPay : IPaymentMethod
	//{
	//	public void Pay(decimal amount)
	//	{
	//		//Logic to pay with cash
	//	}
	//}

	#endregion
}
