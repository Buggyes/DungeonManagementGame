using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Management_Game
{
	public class Castle
	{
		public int gold { get; set; }
		public int morale { get; set; }
		public List<Minion> minion;
		public Castle()
		{
			this.gold = 0;
			this.morale = 0;
			minion = new List<Minion>();
		}
	}
}
