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

        private Pokemon _currentPlayerPokemon;
        public Pokemon CurrentPlayerPokemon => _currentPlayerPokemon;
        public Pokemon CurrentEnemyPokemon { get; private set; }
        public bool IsBossFight => CombatNumber % 10 == 0;
        private Random rng = new();

        public GameSession(List<Pokemon> team)
        {
            // Clone profond pour éviter de manipuler la team du joueur directement
            Team = team.Select(p => p.Clone()).ToList();
            // Toujours sélectionner le premier vivant
            _currentPlayerIndex = Team.FindIndex(p => p.PV > 0);
            if (_currentPlayerIndex == -1)
                throw new ArgumentException("Aucun Pokémon vivant dans l'équipe !");
        }

        public void NextCombat()
        {
            // Soigne tous les Pokémon de l'équipe entre chaque combat (option RPG classique)
            foreach (var p in Team)
            {
                p.PV = p.PVMax;
                foreach (var atk in p.Attaques)
                    atk.PP = atk.PPMax;
            }
            // Sélectionne le premier Pokémon vivant
            _currentPlayerIndex = Team.FindIndex(p => p.PV > 0);
            if (_currentPlayerIndex == -1)
                throw new ArgumentException("Aucun Pokémon vivant pour le combat !");
            // ... suite inchangée ...
            if (IsBossFight)
                CurrentEnemyPokemon = GenerateBoss(CombatNumber / 10);
            else
                CurrentEnemyPokemon = GenerateRandomPokemon();

            CombatNumber++;
        }
        public void SwitchToPokemon(Pokemon nouveau)
        {
            if (Team.Contains(nouveau) && nouveau.PV > 0)
            {
                _currentPlayerPokemon = nouveau;
            }
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
            // Boucle pour revenir au début si besoin
            for (int i = 0; i < _currentPlayerIndex; ++i)
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
            // Filtre selon le nombre de combats
            int maxLevel = Math.Min(10 + CombatNumber, 100); // Ex: 10 combats -> niv max 20
            var possibles = PokemonDatabase.Data.Values
                .Where(p => p.Niveau <= maxLevel && p.Espece == EspecePokemon.Classique)
                .ToList();

            if (!possibles.Any())
                possibles = PokemonDatabase.Data.Values.Where(p => p.Espece == EspecePokemon.Classique).ToList();

            var rng = new Random();
            var basePkmn = possibles[rng.Next(possibles.Count)];

            // Clone profond pour éviter de modifier l’original
            var wild = new Pokemon
            {
                Numero = basePkmn.Numero,
                Nom = basePkmn.Nom,
                Niveau = basePkmn.Niveau,
                Types = new List<TypePokemon>(basePkmn.Types),
                PV = basePkmn.PVMax,
                PVMax = basePkmn.PVMax,
                Attaque = basePkmn.Attaque,
                Defense = basePkmn.Defense,
                AttaqueSpe = basePkmn.AttaqueSpe,
                DefenseSpe = basePkmn.DefenseSpe,
                Vitesse = basePkmn.Vitesse,
                Stade = basePkmn.Stade,
                ImageFace = basePkmn.ImageFace,
                ImageDos = basePkmn.ImageDos,
                Description = basePkmn.Description,
                Exp = basePkmn.Exp,
                ExpDonnee = basePkmn.ExpDonnee,
                Espece = basePkmn.Espece,
                NiveauEvolution = basePkmn.NiveauEvolution,
                Evolution = basePkmn.Evolution,
                CoutEquipe = basePkmn.CoutEquipe,
                Attaques = basePkmn.Attaques.Select(a => new Attaque
                {
                    Nom = a.Nom,
                    Type = a.Type,
                    Puissance = a.Puissance,
                    PP = a.PPMax,
                    PPMax = a.PPMax,
                    Description = a.Description
                }).ToList(),
                LevelUpMoves = basePkmn.LevelUpMoves?.Select(m => new Pokemon.LevelUpMove
                {
                    Level = m.Level,
                    Move = new Attaque
                    {
                        Nom = m.Move.Nom,
                        Type = m.Move.Type,
                        Puissance = m.Move.Puissance,
                        PP = m.Move.PPMax,
                        PPMax = m.Move.PPMax,
                        Description = m.Move.Description
                    }
                }).ToList() ?? new List<Pokemon.LevelUpMove>()
            };
            return wild;
        }

    }
}
