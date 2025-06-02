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
        public Pokemon CurrentPlayerPokemon => Team.Count > 0 && _currentPlayerIndex >= 0 && _currentPlayerIndex < Team.Count ? Team[_currentPlayerIndex] : null;
        public Pokemon CurrentEnemyPokemon { get; private set; }
        public bool IsBossFight => CombatNumber % 10 == 0;
        private Random rng = new();

        public GameSession(List<Pokemon> team)
        {
            Team = team;
            // Sélectionne le premier vivant
            _currentPlayerIndex = Team.FindIndex(p => p.PV > 0);
        }

        public void NextCombat()
        {
            _currentPlayerIndex = Team.FindIndex(p => p.PV > 0);
            if (_currentPlayerIndex == -1 || Team.Count == 0)
                throw new Exception("Aucun Pokémon vivant dans l’équipe pour combattre !");

            if (IsBossFight)
                CurrentEnemyPokemon = GenerateBoss(CombatNumber / 10);
            else
                CurrentEnemyPokemon = GenerateRandomPokemon();

            CombatNumber++;
        }

        public bool SwitchToPokemon(Pokemon pokemon)
        {
            int index = Team.IndexOf(pokemon);
            if (index != -1 && Team[index].PV > 0)
            {
                _currentPlayerIndex = index;
                return true;
            }
            return false;
        }

        public bool SwitchToNextAlivePlayerPokemon()
        {
            int start = _currentPlayerIndex;
            for (int i = 1; i < Team.Count; ++i)
            {
                int idx = (start + i) % Team.Count;
                if (Team[idx].PV > 0)
                {
                    _currentPlayerIndex = idx;
                    return true;
                }
            }
            return false;
        }

        private Pokemon GenerateBoss(int bossLevel)
        {
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
            int maxLevel = Math.Min(10 + CombatNumber, 100);
            var possibles = PokemonDatabase.Data.Values
                .Where(p => p.Niveau <= maxLevel && p.Espece == EspecePokemon.Classique)
                .ToList();

            if (!possibles.Any())
                possibles = PokemonDatabase.Data.Values.Where(p => p.Espece == EspecePokemon.Classique).ToList();

            var basePkmn = possibles[rng.Next(possibles.Count)];
            return basePkmn.Clone();
        }
    }
}
