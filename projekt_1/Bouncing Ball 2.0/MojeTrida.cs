using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncing_Ball_2._0
{
    internal class MojeTrida
    {
		//barva pozadi
		private static int barevanast = 0;
		public static int Barevanast
        {
			get { return barevanast; }
			set { barevanast = value;}
        }
		//body na vyhru
		private static int bodyNaVyhru = 0;
		public static int BodyNaVyhru
        {
			get { return bodyNaVyhru; }
			set { bodyNaVyhru = value; }
        }
		//rychlost hracu
		private static int rychlostHracu = 0;
		public static int RychlostHracu
		{
			get { return rychlostHracu; }
			set { rychlostHracu = value; }
		}
		//rychlost mice
		private static int rychlostMice = 0;
		public static int RychlostMice
        {
			get { return rychlostMice; }
			set { rychlostMice = value; }
        }
		//barva hracu
		private static int barvyHracu = 0;
		public static int BarvyHracu
        {
			get { return barvyHracu; }
			set { barvyHracu = value; }
        }
	}
}
