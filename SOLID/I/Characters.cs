using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.I
{
	public interface ICharacter
	{
		int Defend();

		int MeleeAtack();

		int Shoot();

		int CastSpell();
	}


	public class Wizard : ICharacter
	{
		// Реализация логики поведения мага.
	}

	public class Swordsman : ICharacter
	{
		// Реализация логики поведения воина.
	}

	public class Arch : ICharacter
	{
		// Реализация логики поведения лучника.
	}
}
