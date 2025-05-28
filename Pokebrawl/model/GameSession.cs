using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebrawl.model
{
    public class GameSession
    {
        public int CombatNumber { get; private set; } = 1;
        public int Money { get; set; } = 0;
        public List<Pokemon> Team { get; }
        private int _currentPlayerIndex = 0;
        public Pokemon CurrentPlayerPokemon => Team[_currentPlayerIndex];
        public Pokemon CurrentEnemyPokemon { get; private set; }
        public bool IsBossFight => CombatNumber % 10 == 0;
        private Random rng = new();

        public GameSession(List<Pokemon> team)
        {
            Team = team;
        }

        public void NextCombat()
        {
            _currentPlayerIndex = 0; // Remet le joueur au début à chaque combat
            if (IsBossFight)
                CurrentEnemyPokemon = GenerateBoss(CombatNumber / 10);
            else
                CurrentEnemyPokemon = GenerateRandomPokemon();

            CombatNumber++;
        }

        public bool SwitchToNextAlivePlayerPokemon()
        {
            for (int i = _currentPlayerIndex + 1; i < Team.Count; ++i)
            {
                if (Team[i].PV > 0)
                {
                    _currentPlayerIndex = i;
                    return true;
                }
            }
            return false;
        }

        private Pokemon GenerateBoss(int bossLevel)
        {
            // À adapter selon tes boss
            return new Pokemon
            {
                Nom = $"Boss {bossLevel}",
                Niveau = bossLevel * 10,
                PV = 40 + bossLevel * 10,
                PVMax = 40 + bossLevel * 10,
                Attaques = Attaque.GetBossAttaques()
            };
        }

        private Pokemon GenerateRandomPokemon()
        {
            var wilds = PokemonDatabase.GetWildPokemons();
            var basePkmn = wilds[rng.Next(wilds.Count)];
            basePkmn.PV = basePkmn.PVMax;
            basePkmn.Niveau = rng.Next(1, 10);
            return basePkmn;
        }
    }
}
