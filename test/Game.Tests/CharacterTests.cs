using System;
using Xunit;

namespace Game.Tests
{
    public class CharacterTests
    {
        Character user = new Character("kora");
        [Fact]
        public void CharacterBuild()
        {
            string name = "kora";
            int lvl = 1;
            int hp = 25;
            int mp = 0;
            int xp = 0;

            Assert.Equal(name,user.getName());
            Assert.Equal(lvl, user.getLevel());
            Assert.Equal(hp, user.getHP());
            Assert.Equal(mp, user.getMP());
            Assert.Equal(xp, user.getXP());

        }
        [Fact]
        public void CharacterInventory(){
            Assert.Equal(10,user.getGold());
        }
    }
}
