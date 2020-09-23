using System;

namespace DesyOOPMath
{
	public class DesyFractNumber
	{
		private int up;
		private int down;

		public int Up
		{
			get
			{
				return up;
			}
			set
			{
				up = value;
			}
		}
		public int Down
		{
			get
			{
				return down;
			}
			set
			{
				down = value;
			}
		}

		
		public DesyFractNumber Add(DesyFractNumber fractional)
		{
			DesyFractNumber FractResult = new DesyFractNumber();

			FractResult.Down = Down * fractional.Down;
			int Pemb1 = (fractional.Down * Up);
			int Pemb2 = (Down * fractional.Up);

			FractResult.Up = Pemb1 + Pemb2;
			int hasil = GCD(FractResult.Up, FractResult.Down);
			FractResult.Up = FractResult.Up / hasil;
			FractResult.Down = FractResult.Down / hasil;

			return FractResult;
		}

		public DesyFractNumber Minus(DesyFractNumber fractional)
		{
			DesyFractNumber FractResult = new DesyFractNumber();

			FractResult.Down = Down * fractional.Down;
			int Pemb1 = (FractResult.Down / Down) * Up;
			int Pemb2 = (FractResult.Down / fractional.Down) * fractional.Up;

			FractResult.Up = Pemb1 - Pemb2;
			int hasil = GCD(FractResult.Up, FractResult.Down);
			FractResult.Up = FractResult.Up / hasil;
			FractResult.Down = FractResult.Down / hasil;

			return FractResult;
		}

		public DesyFractNumber Multiply(DesyFractNumber Fractional2)
		{
			DesyFractNumber FractResult = new DesyFractNumber();

			FractResult.Up = Up * Fractional2.Up;
			FractResult.Down = Down * Fractional2.Down;

			int hasil = GCD(FractResult.Up, FractResult.Down);
			FractResult.Up = FractResult.Up / hasil;
			FractResult.Down = FractResult.Down / hasil;

			return FractResult;
		}

		public DesyFractNumber Divide(DesyFractNumber Fractional2)
		{
			DesyFractNumber FractResult = new DesyFractNumber();

			FractResult.Up = Up * Fractional2.Down;
			FractResult.Down = Down * Fractional2.Up;

			int hasil = GCD(FractResult.Up, FractResult.Down);
			FractResult.Up = FractResult.Up / hasil;
			FractResult.Down = FractResult.Down / hasil;

			return FractResult;
		}

		public void SetFractNumber(int f1, int f2)
		{
			Up = f1;
			Down = f2;
		}

		private int GCD (int Up, int Down)
		{
			while (Up != Down)
			{
				if (Up > Down)
				{
					Up  = Up - Down;
				}

				else
				{
					Down = Down - Up ;
				}
		
			}

			return Up;
		}


	}
}

