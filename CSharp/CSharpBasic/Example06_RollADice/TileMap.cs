using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06_RollADice
{
    public class TileMap
    {
        private Dictionary<int, Tileinfo> tiles = new Dictionary<int, Tileinfo>();

        public void MapSetUp(int maxTileNum)
        {
            for (int i = 0; i < maxTileNum; i++)
            {
                if (i % 5 == 0)
                {
                    Tileinfo tileinfo_Star = new Tileinfo_Star();
                    tileinfo_Star.index = i;
                    tileinfo_Star.name = "샛별 칸";
                    tileinfo_Star.description = "샛별을 획득할 수 있는 칸입니다.";
                    tiles.Add(i, tileinfo_Star);
                }
                else
                {
                    Tileinfo tileinfo = new Tileinfo();
                    tileinfo.index = i;
                    tileinfo.name = "일반 칸";
                    tileinfo.description = "아무 이벤트가 없습니다.";
                    tiles.Add(i, tileinfo);
                }
            }
        }

        public bool TryGetTileInfo(int index, out Tileinfo tileinfo)
            =>tiles.TryGetValue(index, out tileinfo);
            
    }
}
