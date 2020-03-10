using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.D
{
	public interface IMessenger
	{
		void Send();
	}

	public class Email : IMessenger
	{
		public void Send()
		{
		}
	}

	public class SMS : IMessenger
	{
		public void Send()
		{
		}
	}

	//Способы внедрения зависимостей

	//Конструктор
	public class Reminding1
	{
		private IMessenger _messenger;

		public Reminding1(IMessenger messenger)
		{
			_messenger = messenger;
		}

		public void Notify()
		{
			_messenger.Send();
		}
	}

	//Свойства
	public class Reminding2
	{
		private IMessenger _messenger;
		public IMessenger Messanger
		{
			set
			{
				_messenger = value;
			}
		}

		public Reminding2(IMessenger messenger)
		{
			_messenger = messenger;
		}

		public void Notify()
		{
			_messenger.Send();
		}
	}

	//Метод
	public class Reminding
	{
		/// <param name="messenger"> Интерфейс для отправки сообщений. </param>
		public void Notify(IMessenger messenger)
		{
			messenger.Send();
		}
	}
}
