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
	}

	public interface IPhysicalImpact
	{
		int MeleeAtack();

		int Shoot();
	}

	public interface IMagicalImpact
	{
		int CastSpell();
	}

	public class Wizard : ICharacter, IMagicalImpact
	{
		// Реализация логики поведения мага.
	}

	public class Swordsman : ICharacter, IPhysicalImpact
	{
		// Реализация логики поведения воина.
	}

	public class Arch : ICharacter, IPhysicalImpact
	{
		// Реализация логики поведения лучника.
	}
}
