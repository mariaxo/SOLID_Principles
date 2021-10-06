using System;
using System.Collections.Generic;

namespace SOLID_Examples
{
	//If S is a subtype of T, then objects of type T may be replaced with objects of type S 

	//Ex: Whatever can be started, driven, has 4 wheels, can upshift and downshift is a car, right?
	//A BMW can do all of these, but a Tesla can't, so wheter a Tesla is not a car, or the definition of a car which's above is not right

	class GearBox
	{
		public int CountOfGears { get; set; }
		public int CurrentGear { get; set; }

		private readonly List<int> _gears;

		public GearBox(int countOfGears)
		{
			this.CountOfGears = countOfGears;

			for (int i = -1; i <= CountOfGears; i++)
			{
				_gears.Add(i);
			}

			CurrentGear = _gears[1];
		}

		public void UpShift()
		{
			if (this.CurrentGear < this.CountOfGears)
				this.CurrentGear++;
		}

		public void DownShift()
		{
			if (this.CurrentGear > 0)
				this.CurrentGear--;
		}

	}
	abstract class Car
	{
		protected readonly GearBox GearBox;

		public Car(int countOfGears)
		{
			this.GearBox = new GearBox(countOfGears);
		}

		public abstract void Drive();
		public abstract void UpShift();
		public abstract void DownShift();
	}

	class Toyota : Car
	{
		public Toyota(int countOfGears) : base(countOfGears)
		{

		}

		public override void Drive()
		{
			if (this.GearBox.CurrentGear != 0)
			{
				//Move()
			}
		}
		public override void UpShift()
		{
			this.GearBox.UpShift();
		}
		public override void DownShift()
		{
			this.GearBox.DownShift();
		}
	}

	class Tesla : Car
	{
		public Tesla() : base(1)
		{

		}

		public override void Drive()
		{
			if (this.GearBox.CurrentGear == 1)
			{
				//Move()
			}
		}
		public override void UpShift()
		{
			//This breaks the Liskov Substitution principle
			throw new Exception("A tesla has only one gear, it cannot upshift.");
		}
		public override void DownShift()
		{
			//This breaks the Liskov Substitution principle
			throw new Exception("A tesla has only one gear, it cannot upshift.");
		}
	}
}
