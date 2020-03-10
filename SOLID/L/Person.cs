using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
	public class Person
	{
		public virtual void GetJob()
		{

		}

		public virtual void SeeTheLight()
		{

		}
	}

	public class Child : Person
	{
		public override void GetJob()
		{
			throw new NotImplementedException("Ребенок не может работать.");
		}
	}

	public class Adult : Person
	{
		public override void GetJob()
		{
			base.GetJob();
		}
	}
}
